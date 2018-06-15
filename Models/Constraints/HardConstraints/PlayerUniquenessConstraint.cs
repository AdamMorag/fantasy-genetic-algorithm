using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.HardConstraints
{
    public class PlayerUniquenessConstraint : HardConstraint
    {
        public override bool ValidateSolution(IEnumerable<Player> players)
        {
            return !players.GroupBy(p => p.id).Any(x => x.Count() > 1);
        }
    }
}
