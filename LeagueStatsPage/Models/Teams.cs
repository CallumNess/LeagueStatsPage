using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using LeagueStatsPage.Data;
using Microsoft.EntityFrameworkCore;

namespace LeagueStatsPage.Models
{
    public class Teams
    {
        public int TeamsID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }

        public IList<TournamentTeam> TournamentTeams { get; set; }
    }
}
