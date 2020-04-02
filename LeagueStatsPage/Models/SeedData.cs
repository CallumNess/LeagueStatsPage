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
                     },

                   new PlayerDetails
                   {
                       Name = "Expect",
                       Age = 1,
                       DOB = new DateTime(2019, 07, 04),
                       Team = "Excel Esports",
                       StartDate = new DateTime(2018,12,07)
                   },

                    new PlayerDetails
                    {
                        Name = "Caedrel",
                        Age = 24,
                        DOB = new DateTime(1996,03,19),
                        Team = "Excel Esports",
                        StartDate = new DateTime(2018,12,02)
                    },

                    new PlayerDetails
                    {
                        Name = "Mickey",
                        Age = 22,
                        DOB = new DateTime(1997, 07, 15),
                        Team = "Excel Esports",
                        StartDate = new DateTime(2019,11,29)
                    },

                    new PlayerDetails
                    {
                        Name = "Patrik",
                        Age = 19,
                        DOB = new DateTime(2000, 04, 07),
                        Team = "Excel Esports",
                        StartDate = new DateTime(2019, 12, 04)
                    },

                     new PlayerDetails
                     {
                         Name = "Tore",
                         Age = 20,
                         DOB = new DateTime(1999, 12, 27),
                         Team = "Excel Esports",
                         StartDate = new DateTime(2019, 12, 06)
                     },

                      new PlayerDetails
                      {
                          Name = "Sacre",
                          Age = 23,
                          DOB = new DateTime(1996, 09, 07),
                          Team = "SK Gaming",
                          StartDate = new DateTime(2019, 05, 22)
                      },

                    new PlayerDetails
                    {
                        Name = "Trick",
                        Age = 24,
                        DOB = new DateTime(1995, 07, 11),
                        Team = "SK Gaming",
                        StartDate = new DateTime(2019, 12, 16)
                    },

                    new PlayerDetails
                    {
                        Name = "Jenax",
                        Age = 21,
                        DOB = new DateTime(1998, 12, 10),
                        Team = "SK Gaming",
                        StartDate = new DateTime(2019, 08, 01)
                    },

                    new PlayerDetails
                    {
                        Name = "Crownshot",
                        Age = 21,
                        DOB = new DateTime(1998, 04, 17),
                        Team = "SK Gaming",
                        StartDate = new DateTime(2018, 12, 20)
                    },

                     new PlayerDetails
                     {
                         Name = "LIMIT",
                         Age = 22,
                         DOB = new DateTime(1997, 12, 27),
                         Team = "SK Gaming",
                         StartDate = new DateTime(2019, 12, 16)
                     },

                     new PlayerDetails
                       {
                        Name = "Bwipo",
                        Age = 21,
                        DOB = new DateTime(1998, 12, 24),
                        Team = "Fnatic",
                        StartDate = new DateTime(2018, 01, 07)
                       },

                    new PlayerDetails
                    {
                        Name = "Selfmade",
                        Age = 20,
                        DOB = new DateTime(1999, 12, 15),
                        Team = "Fnatic",
                        StartDate = new DateTime(2019, 11, 21)
                    },

                    new PlayerDetails
                    {
                        Name = "Nemesis",
                        Age = 20,
                        DOB = new DateTime(1999, 07, 26),
                        Team = "Fnatic",
                        StartDate = new DateTime(2018, 11, 29)
                    },

                    new PlayerDetails
                    {
                        Name = "Rekkles",
                        Age = 23,
                        DOB = new DateTime(1996, 09, 20),
                        Team = "Fnatic",
                        StartDate = new DateTime(2015, 05, 14)
                    },

                     new PlayerDetails
                     {
                         Name = "Hylissang",
                         Age = 24,
                         DOB = new DateTime(1995, 04, 30),
                         Team = "Fnatic",
                         StartDate = new DateTime(2017, 12, 14)
                     },

                    new PlayerDetails
                    {
                        Name = "Odoamne",
                        Age = 25,
                        DOB = new DateTime(1995, 01, 18),
                        Team = "FC Schalke 04 Esports",
                        StartDate = new DateTime(2018, 12, 12)
                    },

                    new PlayerDetails
                    {
                        Name = "Gilius",
                        Age = 23,
                        DOB = new DateTime(1997, 01, 05),
                        Team = "FC Schalke 04 Esports",
                        StartDate = new DateTime(2019, 12, 10)
                    },

                    new PlayerDetails
                    {
                        Name = "Abbedagge",
                        Age = 1,
                        DOB = new DateTime(2019, 09, 10),
                        Team = "FC Schalke 04 Esports",
                        StartDate = new DateTime(2018, 11, 30)
                    },

                    new PlayerDetails
                    {
                        Name = "Innaxe",
                        Age = 21,
                        DOB = new DateTime(1999, 03, 23),
                        Team = "FC Schalke 04 Esports",
                        StartDate = new DateTime(2020, 02, 13)
                    },

                     new PlayerDetails
                     {
                         Name = "Dreams",
                         Age = 1,
                         DOB = new DateTime(2019, 03, 07),
                         Team = "FC Schalke 04 Esports",
                         StartDate = new DateTime(2019, 12, 02)
                     },

                      new PlayerDetails
                    {
                        Name = "Orome",
                        Age = 1,
                        DOB = new DateTime(2019, 01, 16),
                        Team = "MAD Lions",
                        StartDate = new DateTime(2019, 11, 29)
                    },

                    new PlayerDetails
                    {
                        Name = "Shad0w",
                        Age = 19,
                        DOB = new DateTime(2001, 02, 25),
                        Team = "MAD Lions",
                        StartDate = new DateTime(2019, 11, 29)
                    },

                    new PlayerDetails
                    {
                        Name = "Humanoid",
                        Age = 20,
                        DOB = new DateTime(2000, 03, 14),
                        Team = "MAD Lions",
                        StartDate = new DateTime(2019, 11, 29)
                    },

                    new PlayerDetails
                    {
                        Name = "Carzzy",
                        Age = 18,
                        DOB = new DateTime(2002, 01, 31),
                        Team = "MAD Lions",
                        StartDate = new DateTime(2019, 11, 29)
                    },

                     new PlayerDetails
                     {
                         Name = "Kaiser",
                         Age = 21,
                         DOB = new DateTime(1998, 11, 19),
                         Team = "MAD Lions",
                         StartDate = new DateTime(2019, 11, 29)
                     },

                        new PlayerDetails
                    {
                        Name = "Alphari",
                        Age = 20,
                        DOB = new DateTime(1999, 10, 20),
                        Team = "Origen",
                        StartDate = new DateTime(2018, 12, 03)
                    },

                    new PlayerDetails
                    {
                        Name = "Xerxe",
                        Age = 20,
                        DOB = new DateTime(1999, 11, 05),
                        Team = "Origen",
                        StartDate = new DateTime(2019, 11, 19)
                    },

                    new PlayerDetails
                    {
                        Name = "Nukeduck",
                        Age = 23,
                        DOB = new DateTime(1996, 05, 21),
                        Team = "Origen",
                        StartDate = new DateTime(2018, 12, 03)
                    },

                    new PlayerDetails
                    {
                        Name = "Upset",
                        Age = 20,
                        DOB = new DateTime(1999, 12, 16),
                        Team = "Origen",
                        StartDate = new DateTime(2019, 11, 19)
                    },

                     new PlayerDetails
                     {
                         Name = "Destiny",
                         Age = 22,
                         DOB = new DateTime(1997, 10, 27),
                         Team = "Origen",
                         StartDate = new DateTime(2019, 11, 19)
                     },

                    new PlayerDetails
                    {
                        Name = "Dan Dan",
                        Age = 24,
                        DOB = new DateTime(1995, 09, 07),
                        Team = "Misfits Gaming",
                        StartDate = new DateTime(2019, 07, 18)
                    },

                    new PlayerDetails
                    {
                        Name = "Razork",
                        Age = 19,
                        DOB = new DateTime(2000, 10, 07),
                        Team = "Misfits Gaming",
                        StartDate = new DateTime(2019, 12, 06)
                    },

                    new PlayerDetails
                    {
                        Name = "Febiven",
                        Age = 23,
                        DOB = new DateTime(1996, 09, 23),
                        Team = "Misfits Gaming",
                        StartDate = new DateTime(2018, 11, 20)
                    },

                    new PlayerDetails
                    {
                        Name = "Bvoy",
                        Age = 22,
                        DOB = new DateTime(1997, 12, 18),
                        Team = "Misfits Gaming",
                        StartDate = new DateTime(2019, 12, 06)
                    },

                    new PlayerDetails
                    {
                        Name = "Denyk",
                        Age = 24,
                        DOB = new DateTime(1995, 04, 30),
                        Team = "Misfits Gaming",
                        StartDate = new DateTime(2019, 12, 06)
                    }
                );
            context.SaveChanges();
            }
        }
    }
