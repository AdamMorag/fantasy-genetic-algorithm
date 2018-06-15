using fantasy_genetic_algorithm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace fantasy_genetic_algorithm
{
    public class TeamSuggestionController : ApiController
    {
        [Route("Suggestion")]
        [HttpPost]
        public IEnumerable<Player> PostSuggestion([FromBody]Player[] players)
        {
            var algorithm = new FantasyGeneticAlgorithm(players);

            return algorithm.FindSolution();
        }
    }
}
