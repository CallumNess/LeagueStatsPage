using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class TournamentTeam
    {
        public int TournamentID { get; set; }
        public Tournament Tournament { get; set; }

        public int TeamsID { get; set; }
        public Teams Teams { get; set; }
    }
}
