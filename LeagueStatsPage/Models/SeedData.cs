using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LeagueStatsPage.Data;
using System;
using System.Linq;

namespace LeagueStatsPage.Models
{
    public static class SeedData
    {
        public static void Initialize(LeagueStatsPageContext context)
        {
            context.Database.EnsureCreated();    
            
           

            // Look for any players.
                if (context.PlayerDetails.Any())
                {
                    var players = context.PlayerDetails;
                    context.RemoveRange(players);
                    context.SaveChanges();
                }

                context.PlayerDetails.AddRange(
                    new PlayerDetails
                    {
                        Name = "Wunder",
                        Age = 21,
                        DOB = new DateTime(1998,11,09),
                        Team = "G2 Esports",
                        StartDate = new DateTime(2017,12,8)
                    },

                    new PlayerDetails
                    {
                        Name = "Jankos",
                        Age = 24,
                        DOB = new DateTime(1995,07,23),
                        Team = "G2 Esports",
                        StartDate = new DateTime(2017, 12, 8)
                    },

                    new PlayerDetails
                    {
                        Name = "Perkz",
                        Age = 21,
                        DOB = new DateTime(1998,09,30),
                        Team = "G2 Esports",
                        StartDate = new DateTime(2015,06,02)
                    },

                    new PlayerDetails
                    {
                        Name = "Caps",
                        Age = 20,
                        DOB = new DateTime(1999,11,17),
                        Team = "G2 Esports",
                        StartDate = new DateTime(2018,11,29)
                    },

                     new PlayerDetails
                     {
                         Name = "Mikyx",
                         Age = 21,
                         DOB = new DateTime(1998,11,02),
                         Team = "G2 Esports",
                         StartDate = new DateTime(2018, 11, 29)
                     }
                );
                context.SaveChanges();
            }
        }
    }
