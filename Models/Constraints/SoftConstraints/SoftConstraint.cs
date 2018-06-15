using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.SoftConstraints
{
    public abstract class SoftConstraint : Constraint
    {
        private float weight;

        public SoftConstraint(float weight)
        {
            this.weight = weight;
        }

        public override double CalculateFitness(IEnumerable<Player> players)
        {
            return this.CalculateRawFitness(players) * weight;
        }

        protected abstract double CalculateRawFitness(IEnumerable<Player> players);
    }
}
