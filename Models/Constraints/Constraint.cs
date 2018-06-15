using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace fantasy_genetic_algorithm.Models
{
    public abstract class Constraint
    {
        public abstract double CalculateFitness(IEnumerable<Player> players);
    }
}
