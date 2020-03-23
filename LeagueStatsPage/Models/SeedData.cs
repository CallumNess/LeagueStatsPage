using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LeagueStatsPage.Data;
using System;
using System.Linq;

namespace LeagueStatsPage.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LeagueStatsPageContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LeagueStatsPageContext>>()))
            {
                // Look for any players.
                if (context.PlayerDetails.Any())
                {
                    return;   // DB has been seeded
                }

                context.PlayerDetails.AddRange(
                    new PlayerDetails
                    {
                        Name = "Wunder",
                        Age = Convert.ToInt32("21"),
                        DOB = DateTime.Parse("1998-11-09"),
                        Team = "G2 Esports"
                    },

                    new PlayerDetails
                    {
                        Name = "Jankos",
                        Age = Convert.ToInt32("24"),
                        DOB = DateTime.Parse("1995-07-23"),
                        Team = "G2 Esports"
                    },

                    new PlayerDetails
                    {
                        Name = "Perkz",
                        Age = Convert.ToInt32("21"),
                        DOB = DateTime.Parse("1998-09-30"),
                        Team = "G2 Esports"
                    },

                    new PlayerDetails
                    {
                        Name = "Caps",
                        Age = Convert.ToInt32("20"),
                        DOB = DateTime.Parse("1999-11-17"),
                        Team = "G2 Esports"
                    },

                     new PlayerDetails
                     {
                         Name = "Mikyx",
                         Age = Convert.ToInt32("21"),
                         DOB = DateTime.Parse("1998-11-02"),
                         Team = "G2 Esports"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}