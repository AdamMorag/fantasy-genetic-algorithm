using fantasy_genetic_algorithm.Models.Constraints.SoftConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints
{
    public class BudgetUtilizationConstraint : SoftConstraint
    {
        private readonly int MAX_BUDGET;

        public BudgetUtilizationConstraint(int maxBudget, float weight) : base(weight)
        {
            this.MAX_BUDGET = maxBudget;
        }

        protected override double CalculateRawFitness(IEnumerable<Player> players)
        {                        
            int budget = players.Sum(p => p.marketValue);

            return budget / this.MAX_BUDGET;
        }
    }
}
