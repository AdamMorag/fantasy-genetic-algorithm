using fantasy_genetic_algorithm.Models;
using fantasy_genetic_algorithm.Models.Constraints;
using fantasy_genetic_algorithm.Models.Constraints.HardConstraints;
using fantasy_genetic_algorithm.Models.Constraints.SoftConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm
{
    public class FitnessCaclulator
    {
        const int MAX_BUDGET = 100000000;
        const int MAX_PLAYERS_PER_TEAM = 2;        

        private List<HardConstraint> hardConstraints;
        private List<SoftConstraint> softConstraints;        

        public FitnessCaclulator(int maxPlayerValue)
        {            
            this.hardConstraints = initializeHardConstraints();
            this.softConstraints = initializeSoftConstraints(maxPlayerValue);
        }

        public double CalculateFitness(IEnumerable<Player> players)
        {
            if (this.hardConstraints.Any(c => !c.ValidateSolution(players)))
                return 0;

            var fitness = this.softConstraints.Sum(c => c.CalculateFitness(players));

            if (fitness > 1)
                fitness = 1;

            if (fitness < 0)
                fitness = 0;

            return fitness;
        }
        
        public void PrintFitnessDetails(IEnumerable<Player> players)
        {
            this.hardConstraints.ForEach(c => Console.WriteLine("Constraint:{0}, Result:{1}", c.GetType().Name, c.ValidateSolution(players)));
            this.softConstraints.ForEach(c => Console.WriteLine("Constraint:{0}, Result:{1}", c.GetType().Name, c.CalculateFitness(players)));
        }       

        private List<HardConstraint> initializeHardConstraints()
        {
            var config = new RoleCompositionConstraintConfig(1, 1, 3, 5, 3, 5, 1, 3);
            var roleComposition = new RoleCompositionConstraint(config);
            var teamComposition = new TeamCompositionConstraint(MAX_PLAYERS_PER_TEAM);
            var teamCost = new TeamCostConstraint(MAX_BUDGET);
            var playerUniqueness = new PlayerUniquenessConstraint();

            return new List<HardConstraint>()
            {
                playerUniqueness,
                roleComposition,
                teamComposition,
                teamCost
            };
        }

        private List<SoftConstraint> initializeSoftConstraints(int maxPlayerValue)
        {
            var budgetUtiliztion = new BudgetUtilizationConstraint(MAX_BUDGET, 0.5f);
            var medianConstraint = new MedianConstraint(maxPlayerValue, 0.5f);

            return new List<SoftConstraint>()
            {
                budgetUtiliztion,
                medianConstraint
            };
        }
    }
}
