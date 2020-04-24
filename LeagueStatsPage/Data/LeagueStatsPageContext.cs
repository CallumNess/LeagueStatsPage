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
                new Teams { TeamsID = 10, TeamName = "Team Vitality" },
                new Teams { TeamsID = 11, TeamName = "100 Thieves" },
                new Teams { TeamsID = 12, TeamName = "Cloud 9" },
                new Teams { TeamsID = 13, TeamName = "CLG" },
                new Teams { TeamsID = 14, TeamName = "Dignitas" },
                new Teams { TeamsID = 15, TeamName = "Evil Geniuses" },
                new Teams { TeamsID = 16, TeamName = "FlyQuest" },
                new Teams { TeamsID = 17, TeamName = "Golden Guardians" },
                new Teams { TeamsID = 18, TeamName = "Immortals" },
                new Teams { TeamsID = 19, TeamName = "Team Liquid" },
                new Teams { TeamsID = 20, TeamName = "Team SoloMid" },
                new Teams { TeamsID = 21, TeamName = "Afreeca Freecs" },
                new Teams { TeamsID = 22, TeamName = "APK Prince" },
                new Teams { TeamsID = 23, TeamName = "DAMWON Gaming" },
                new Teams { TeamsID = 24, TeamName = "DragonX" },
                new Teams { TeamsID = 25, TeamName = "Gen.G" },
                new Teams { TeamsID = 26, TeamName = "Griffin" },
                new Teams { TeamsID = 27, TeamName = "Hanwha Life" },
                new Teams { TeamsID = 28, TeamName = "KT Rolster" },
                new Teams { TeamsID = 29, TeamName = "SANDBOX Gaming" },
                new Teams { TeamsID = 30, TeamName = "T1" },
                new Teams { TeamsID = 31, TeamName = "Bilibili Gaming" },
                new Teams { TeamsID = 32, TeamName = "Dominus Esports" },
                new Teams { TeamsID = 33, TeamName = "EDward Gaming" },
                new Teams { TeamsID = 34, TeamName = "eStar" },
                new Teams { TeamsID = 35, TeamName = "FunPlus Phoenix" },
                new Teams { TeamsID = 36, TeamName = "Invictus Gaming" },
                new Teams { TeamsID = 37, TeamName = "JD Gaming" },
                new Teams { TeamsID = 38, TeamName = "LGD Gaming" },
                new Teams { TeamsID = 39, TeamName = "LNG Esports" },
                new Teams { TeamsID = 40, TeamName = "Oh My God" },
                new Teams { TeamsID = 41, TeamName = "Rogue Warriors" },
                new Teams { TeamsID = 42, TeamName = "RNG" },
                new Teams { TeamsID = 43, TeamName = "Suning" },
                new Teams { TeamsID = 44, TeamName = "Team WE" },
                new Teams { TeamsID = 45, TeamName = "Top Esports" },
                new Teams { TeamsID = 46, TeamName = "Vici Gaming" },
                new Teams { TeamsID = 47, TeamName = "Victory Five" }
                );
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
