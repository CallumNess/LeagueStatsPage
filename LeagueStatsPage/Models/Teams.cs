using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueStatsPage.Data;
using Microsoft.EntityFrameworkCore;

namespace LeagueStatsPage.Models
{
    public class Teams
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
    }
}
