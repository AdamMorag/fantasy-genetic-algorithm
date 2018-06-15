using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models.Constraints.HardConstraints
{
    public class RoleCompositionConstraint : HardConstraint
    {
        private RoleCompositionConstraintConfig config;

        public RoleCompositionConstraint(RoleCompositionConstraintConfig config)
        {
            this.config = config;
        }

        public override bool ValidateSolution(IEnumerable<Player> players)
        {
            return players.GroupBy(p => p.type).All(roles => {
                var roleAmountConfig = this.config.config[roles.Key];
                var roleCount = roles.Count();                

                return roleAmountConfig.IsValidAmount(roleCount);
            });
        }
    }
}
