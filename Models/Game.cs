using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boccee_Ball_League.Models
{
    class Game
    {
        public int ID { get; set; }

        // many to many.
        public int? HomeTeamID { get; set; }
        public Team HomeTeam { get; set; }

        public int? AwayTeamID { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public DateTime DateHappened { get; set; }
        public string Notes { get; set; }

        // 
        public ICollection<Team> Team { get; set; } = new HashSet<Team>();
    }
}
