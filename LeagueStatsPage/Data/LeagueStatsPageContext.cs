using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeagueStatsPage.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LeagueStatsPage.Data
{
    public class LeagueStatsPageContext : DbContext
    {

        public DbSet<PlayerDetails> PlayerDetails { get; set; }
        public DbSet<Teams> Teams {get; set;}


        public LeagueStatsPageContext()
        {
            
        }
        public LeagueStatsPageContext(DbContextOptions<LeagueStatsPageContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Teams>().HasData(
                new Teams {ID = 1, TeamName = "G2 Esports" },
                new Teams {ID = 2, TeamName = "Excel Esports" },
                new Teams {ID = 3, TeamName = "FC Schalke 04 Esports" },
                new Teams {ID = 4, TeamName = "Fnatic" },
                new Teams {ID = 5, TeamName = "MAD Lions" },
                new Teams {ID = 6, TeamName = "Misfits Gaming" },
                new Teams {ID = 7, TeamName = "Origen" },
                new Teams {ID = 8, TeamName = "Rogue" },
                new Teams {ID = 9, TeamName = "SK Gaming" },
                new Teams {ID = 10, TeamName = "Team Vitality"}
                );
        }
    }
}
