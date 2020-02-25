using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeagueStatsPage.Models;

namespace LeagueStatsPage.Data
{
    public class LeagueStatsPageContext : DbContext
    {
        public LeagueStatsPageContext (DbContextOptions<LeagueStatsPageContext> options)
            : base(options)
        {
        }

        public DbSet<LeagueStatsPage.Models.PlayerDetails> PlayerDetails { get; set; }
    }
}
