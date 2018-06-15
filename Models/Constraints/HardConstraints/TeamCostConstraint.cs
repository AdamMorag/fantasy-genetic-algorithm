using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.HardConstraints
{
    public class TeamCostConstraint : HardConstraint
    {
        private readonly int MAX_TEAM_COST;

        public TeamCostConstraint(int maxTeamCost)
        {
            this.MAX_TEAM_COST = maxTeamCost;
        }

        public override bool ValidateSolution(IEnumerable<Player> players)
        {
            return players.Sum(p => p.marketValue) <= this.MAX_TEAM_COST;
        }
    }
}
