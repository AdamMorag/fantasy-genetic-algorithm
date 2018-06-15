using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints
{
    public abstract class HardConstraint : Constraint
    {
        public override double CalculateFitness(IEnumerable<Player> players)
        {
            return this.ValidateSolution(players) ? 1 : 0;
        }

        public abstract bool ValidateSolution(IEnumerable<Player> players);
    }
}
