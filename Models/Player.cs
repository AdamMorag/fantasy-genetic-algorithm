using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_genetic_algorithm.Models
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public Role type { get; set; }
        public int teamNum { get; set; }
        public string teamName { get; set; }
        public bool isInjured { get; set; }
        public bool isSuspended { get; set; }
        public bool isMissing { get; set; }
        public string teamFlagPic { get; set; }
        public string shirtPicture { get; set; }
        public int pointsValue { get; set; }
        public int marketValue { get; set; }
        public bool existInCurrentStage { get; set; }
        public string hashKey { get; set; }
    }

}
