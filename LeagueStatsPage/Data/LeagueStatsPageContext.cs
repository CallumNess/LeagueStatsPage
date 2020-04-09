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
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentTeam> TournamentTeams { get; set; }

        public LeagueStatsPageContext()
        {
            
        }
        public LeagueStatsPageContext(DbContextOptions<LeagueStatsPageContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Teams>().HasData(
                new Teams { TeamsID = 1, TeamName = "G2 Esports" },
                new Teams { TeamsID = 2, TeamName = "Excel Esports" },
                new Teams { TeamsID = 3, TeamName = "FC Schalke 04 Esports" },
                new Teams { TeamsID = 4, TeamName = "Fnatic" },
                new Teams { TeamsID = 5, TeamName = "MAD Lions" },
                new Teams { TeamsID = 6, TeamName = "Misfits Gaming" },
                new Teams { TeamsID = 7, TeamName = "Origen" },
                new Teams { TeamsID = 8, TeamName = "Rogue" },
                new Teams { TeamsID = 9, TeamName = "SK Gaming" },
                new Teams { TeamsID = 10, TeamName = "Team Vitality" });
                 modelbuilder.Entity<Tournament>().HasData(
                new Tournament { TournamentID = 1, TournamentName = "LEC"},
                new Tournament { TournamentID = 2, TournamentName = "LCS"},
                new Tournament { TournamentID = 5, TournamentName = "LCK"},
                new Tournament { TournamentID = 6, TournamentName = "LPL"},
                new Tournament { TournamentID = 4, TournamentName = "MSI"},
                new Tournament { TournamentID = 3, TournamentName = "Worlds"}
                );
            modelbuilder.Entity<TournamentTeam>().HasKey(tt => new { tt.TournamentID, tt.TeamsID });
        }
    }
}
