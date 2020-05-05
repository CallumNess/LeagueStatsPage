using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class Tournament
    {
        public int TournamentID { get; set; }

        [DisplayName("Tournament Name")]
        public string TournamentName { get; set; }

        public IList<TournamentTeam> TournamentTeams { get; set; }
    }
}
