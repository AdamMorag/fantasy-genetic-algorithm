using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.SoftConstraints
{
    public class MedianConstraint : SoftConstraint
    {
        private readonly int MAX_PLAYER_COST;
        public MedianConstraint(int maxPlayerCost, float weight) : base(weight)
        {
            MAX_PLAYER_COST = maxPlayerCost;
        }

        protected override double CalculateRawFitness(IEnumerable<Player> players)
        {
            var medianCost = this.calculateMedian(players.Select(p => p.marketValue));

            return medianCost / MAX_PLAYER_COST;
        }

        private double calculateMedian(IEnumerable<int> playersCost)
        {
            int numberCount = playersCost.Count();
            int halfIndex = playersCost.Count() / 2;
            var sortedNumbers = playersCost.OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = (sortedNumbers.ElementAt(halfIndex) +
                    sortedNumbers.ElementAt(halfIndex - 1)) / 2;
            }
            else {
                median = sortedNumbers.ElementAt(halfIndex);
            }

            return median;
        }
    }
}
