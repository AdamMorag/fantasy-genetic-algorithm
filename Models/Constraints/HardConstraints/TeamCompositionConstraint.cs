using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.HardConstraints
{
    public class TeamCompositionConstraint : HardConstraint
    {
        private readonly int MAX_PLAYERS_FROM_EACH_TEAM;

        public TeamCompositionConstraint(int maxPlayersFromEachTeam)
        {
            this.MAX_PLAYERS_FROM_EACH_TEAM = maxPlayersFromEachTeam;
        }

        public override bool ValidateSolution(IEnumerable<Player> players)
        {
            return players.GroupBy(p => p.teamNum)
                .All(team => team.Count() <= this.MAX_PLAYERS_FROM_EACH_TEAM);
        }
    }
}
