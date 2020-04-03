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
        public string TeamName { get; set; }

       public ICollection<PlayerDetails> Players { get; set; }
    }
}
