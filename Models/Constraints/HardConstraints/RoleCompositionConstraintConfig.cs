using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models
{
    
    public class RoleAmount
    {
        public int Min;
        public int Max;

        public RoleAmount(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool IsValidAmount(int amount)
        {
            return amount >= this.Min && amount <= this.Max;
        }
    }

    public class RoleCompositionConstraintConfig
    {
        public Dictionary<Role, RoleAmount> config;

        public RoleCompositionConstraintConfig(int minGoalkeepers, int maxGoalkeepers,
            int minDefenders, int maxDefenders, int minMidfielders, int maxMidfielders,
            int minForwards, int maxForwards)
        {
            this.config = new Dictionary<Role, RoleAmount>()
            {
                { Role.g, new RoleAmount(minGoalkeepers, maxGoalkeepers) },
                { Role.d, new RoleAmount(minDefenders, maxDefenders) },
                { Role.m, new RoleAmount(minMidfielders, maxMidfielders) },
                { Role.a, new RoleAmount(minForwards, maxForwards) }
            };
        }
    }
}
