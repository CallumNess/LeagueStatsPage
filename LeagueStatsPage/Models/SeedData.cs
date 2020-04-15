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
                        DOB = new DateTime(1998, 11, 09),
                        TeamsId = 1,
                        StartDate = new DateTime(2017, 12, 8),
                        Nationality = "dk"
                    },

                    new PlayerDetails
                    {
                        Name = "Jankos",
                        Age = 24,
                        DOB = new DateTime(1995, 07, 23),
                        TeamsId = 1,
                        StartDate = new DateTime(2017, 12, 8),
                        Nationality = "pl"
                    },

                    new PlayerDetails
                    {
                        Name = "Perkz",
                        Age = 21,
                        DOB = new DateTime(1998, 09, 30),
                        TeamsId = 1,
                        StartDate = new DateTime(2015, 06, 02),
                        Nationality = "hr"
                    },

                    new PlayerDetails
                    {
                        Name = "Caps",
                        Age = 20,
                        DOB = new DateTime(1999, 11, 17),
                        TeamsId = 1,
                        StartDate = new DateTime(2018, 11, 29),
                        Nationality = "dk"
                    },

                     new PlayerDetails
                     {
                         Name = "Mikyx",
                         Age = 21,
                         DOB = new DateTime(1998, 11, 02),
                         TeamsId = 1,
                         StartDate = new DateTime(2018, 11, 29),
                         Nationality = "si"
                     },

                   new PlayerDetails
                   {
                       Name = "Expect",
                       Age = 1,
                       DOB = new DateTime(2019, 07, 04),
                       TeamsId = 2,
                       StartDate = new DateTime(2018, 12, 07),
                       Nationality = "kr"
                   },

                    new PlayerDetails
                    {
                        Name = "Caedrel",
                        Age = 24,
                        DOB = new DateTime(1996, 03, 19),
                        TeamsId = 2,
                        StartDate = new DateTime(2018, 12, 02),
                        Nationality = "gb"
                    },

                    new PlayerDetails
                    {
                        Name = "Mickey",
                        Age = 22,
                        DOB = new DateTime(1997, 07, 15),
                        TeamsId = 2,
                        StartDate = new DateTime(2019, 11, 29),
                        Nationality = "kr"
                    },

                    new PlayerDetails
                    {
                        Name = "Patrik",
                        Age = 19,
                        DOB = new DateTime(2000, 04, 07),
                        TeamsId = 2,
                        StartDate = new DateTime(2019, 12, 04),
                        Nationality = "cz"
                    },

                     new PlayerDetails
                     {
                         Name = "Tore",
                         Age = 20,
                         DOB = new DateTime(1999, 12, 27),
                         TeamsId = 2,
                         StartDate = new DateTime(2019, 12, 06),
                         Nationality = "no"
                     },

                      new PlayerDetails
                      {
                          Name = "Sacre",
                          Age = 23,
                          DOB = new DateTime(1996, 09, 07),
                          TeamsId = 9,
                          StartDate = new DateTime(2019, 05, 22),
                          Nationality = "hr"
                      },

                    new PlayerDetails
                    {
                        Name = "Trick",
                        Age = 24,
                        DOB = new DateTime(1995, 07, 11),
                        TeamsId = 9,
                        StartDate = new DateTime(2019, 12, 16),
                        Nationality = "kr"
                    },

                    new PlayerDetails
                    {
                        Name = "Jenax",
                        Age = 21,
                        DOB = new DateTime(1998, 12, 10),
                        TeamsId = 9,
                        StartDate = new DateTime(2019, 08, 01),
                        Nationality = "de"
                    },

                    new PlayerDetails
                    {
                        Name = "Crownshot",
                        Age = 21,
                        DOB = new DateTime(1998, 04, 17),
                        TeamsId = 9,
                        StartDate = new DateTime(2018, 12, 20),
                        Nationality = "si"
                    },

                     new PlayerDetails
                     {
                         Name = "LIMIT",
                         Age = 22,
                         DOB = new DateTime(1997, 12, 27),
                         TeamsId = 9,
                         StartDate = new DateTime(2019, 12, 16),
                         Nationality = "hr"
                     },

                     new PlayerDetails
                     {
                         Name = "Bwipo",
                         Age = 21,
                         DOB = new DateTime(1998, 12, 24),
                         TeamsId = 4,
                         StartDate = new DateTime(2018, 01, 07),
                         Nationality = "de"
                     },

                    new PlayerDetails
                    {
                        Name = "Selfmade",
                        Age = 20,
                        DOB = new DateTime(1999, 12, 15),
                        TeamsId = 4,
                        StartDate = new DateTime(2019, 11, 21),
                        Nationality = "pl"
                    },

                    new PlayerDetails
                    {
                        Name = "Nemesis",
                        Age = 20,
                        DOB = new DateTime(1999, 07, 26),
                        TeamsId = 4,
                        StartDate = new DateTime(2018, 11, 29),
                        Nationality = "si"
                    },

                    new PlayerDetails
                    {
                        Name = "Rekkles",
                        Age = 23,
                        DOB = new DateTime(1996, 09, 20),
                        TeamsId = 4,
                        StartDate = new DateTime(2015, 05, 14),
                        Nationality = "se"
                    },

                     new PlayerDetails
                     {
                         Name = "Hylissang",
                         Age = 24,
                         DOB = new DateTime(1995, 04, 30),
                         TeamsId = 4,
                         StartDate = new DateTime(2017, 12, 14),
                         Nationality = "bg"
                     },

                    new PlayerDetails
                    {
                        Name = "Odoamne",
                        Age = 25,
                        DOB = new DateTime(1995, 01, 18),
                        TeamsId = 3,
                        StartDate = new DateTime(2018, 12, 12),
                        Nationality = "ro"
                    },

                    new PlayerDetails
                    {
                        Name = "Gilius",
                        Age = 23,
                        DOB = new DateTime(1997, 01, 05),
                        TeamsId = 3,
                        StartDate = new DateTime(2019, 12, 10),
                        Nationality = "de"
                    },

                    new PlayerDetails
                    {
                        Name = "Abbedagge",
                        Age = 1,
                        DOB = new DateTime(2019, 09, 10),
                        TeamsId = 3,
                        StartDate = new DateTime(2018, 11, 30),
                        Nationality = "de"
                    },

                    new PlayerDetails
                    {
                        Name = "Innaxe",
                        Age = 21,
                        DOB = new DateTime(1999, 03, 23),
                        TeamsId = 3,
                        StartDate = new DateTime(2020, 02, 13),
                        Nationality = "bg"
                    },

                     new PlayerDetails
                     {
                         Name = "Dreams",
                         Age = 1,
                         DOB = new DateTime(2019, 03, 07),
                         TeamsId = 3,
                         StartDate = new DateTime(2019, 12, 02),
                         Nationality = "kr"
                     },

                      new PlayerDetails
                      {
                          Name = "Orome",
                          Age = 1,
                          DOB = new DateTime(2019, 01, 16),
                          TeamsId = 5,
                          StartDate = new DateTime(2019, 11, 29),
                          Nationality = "ro"
                      },

                    new PlayerDetails
                    {
                        Name = "Shad0w",
                        Age = 19,
                        DOB = new DateTime(2001, 02, 25),
                        TeamsId = 5,
                        StartDate = new DateTime(2019, 11, 29),
                        Nationality = "it"
                    },

                    new PlayerDetails
                    {
                        Name = "Humanoid",
                        Age = 20,
                        DOB = new DateTime(2000, 03, 14),
                        TeamsId = 5,
                        StartDate = new DateTime(2019, 11, 29),
                        Nationality = "cz"
                    },

                    new PlayerDetails
                    {
                        Name = "Carzzy",
                        Age = 18,
                        DOB = new DateTime(2002, 01, 31),
                        TeamsId = 5,
                        StartDate = new DateTime(2019, 11, 29),
                        Nationality = "cz"
                    },

                     new PlayerDetails
                     {
                         Name = "Kaiser",
                         Age = 21,
                         DOB = new DateTime(1998, 11, 19),
                         TeamsId = 5,
                         StartDate = new DateTime(2019, 11, 29),
                         Nationality = "de"
                     },

                    new PlayerDetails
                    {
                        Name = "Alphari",
                        Age = 20,
                        DOB = new DateTime(1999, 10, 20),
                        TeamsId = 7,
                        StartDate = new DateTime(2018, 12, 03),
                        Nationality = "gb"
                    },

                    new PlayerDetails
                    {
                        Name = "Xerxe",
                        Age = 20,
                        DOB = new DateTime(1999, 11, 05),
                        TeamsId = 7,
                        StartDate = new DateTime(2019, 11, 19),
                        Nationality = "ro"
                    },

                    new PlayerDetails
                    {
                        Name = "Nukeduck",
                        Age = 23,
                        DOB = new DateTime(1996, 05, 21),
                        TeamsId = 7,
                        StartDate = new DateTime(2018, 12, 03),
                        Nationality = "no"
                    },

                    new PlayerDetails
                    {
                        Name = "Upset",
                        Age = 20,
                        DOB = new DateTime(1999, 12, 16),
                        TeamsId = 7,
                        StartDate = new DateTime(2019, 11, 19),
                        Nationality = "de"
                    },

                     new PlayerDetails
                     {
                         Name = "Destiny",
                         Age = 22,
                         DOB = new DateTime(1997, 10, 27),
                         TeamsId = 7,
                         StartDate = new DateTime(2019, 11, 19),
                         Nationality = "au"
                     },

                    new PlayerDetails
                    {
                        Name = "Dan Dan",
                        Age = 24,
                        DOB = new DateTime(1995, 09, 07),
                        TeamsId = 6,
                        StartDate = new DateTime(2019, 07, 18),
                        Nationality = "es"
                    },

                    new PlayerDetails
                    {
                        Name = "Razork",
                        Age = 19,
                        DOB = new DateTime(2000, 10, 07),
                        TeamsId = 6,
                        StartDate = new DateTime(2019, 12, 06),
                        Nationality = "es"
                    },

                    new PlayerDetails
                    {
                        Name = "Febiven",
                        Age = 23,
                        DOB = new DateTime(1996, 09, 23),
                        TeamsId = 6,
                        StartDate = new DateTime(2018, 11, 20),
                        Nationality = "nl"
                    },

                    new PlayerDetails
                    {
                        Name = "Bvoy",
                        Age = 22,
                        DOB = new DateTime(1997, 12, 18),
                        TeamsId = 6,
                        StartDate = new DateTime(2019, 12, 06),
                        Nationality = "kr"
                    },

                    new PlayerDetails
                    {
                        Name = "Denyk",
                        Age = 24,
                        DOB = new DateTime(1995, 04, 30),
                        TeamsId = 6,
                        StartDate = new DateTime(2019, 12, 06),
                        Nationality = "cz"
                    },

                    new PlayerDetails
                    {
                        Name = "Finn",
                        Age = 20,
                        DOB = new DateTime(1999, 06, 03),
                        TeamsId = 8,
                        StartDate = new DateTime(2019, 02, 12),
                        Nationality = "se"
                    },

                    new PlayerDetails
                    {
                        Name = "Inspired",
                        Age = 18,
                        DOB = new DateTime(2002, 01, 24),
                        TeamsId = 8,
                        StartDate = new DateTime(2019, 05, 27),
                        Nationality = "pl"
                    },

                    new PlayerDetails
                    {
                        Name = "Larssen",
                        Age = 20,
                        DOB = new DateTime(2000, 03, 30),
                        TeamsId = 8,
                        StartDate = new DateTime(2019, 05, 28),
                        Nationality = "se"
                    },

                    new PlayerDetails
                    {
                        Name = "Hans Sama",
                        Age = 20,
                        DOB = new DateTime(1999, 09, 02),
                        TeamsId = 8,
                        StartDate = new DateTime(2019, 11, 18),
                        Nationality = "nl"
                    },

                    new PlayerDetails
                    {
                        Name = "Vander",
                        Age = 25,
                        DOB = new DateTime(1994, 04, 18),
                        TeamsId = 8,
                        StartDate = new DateTime(2019, 02, 12),
                        Nationality = "pl"
                    },

                    new PlayerDetails
                    {
                        Name = "Cabochard",
                        Age = 22,
                        DOB = new DateTime(1997, 04, 14),
                        TeamsId = 10,
                        StartDate = new DateTime(2015, 12, 14),
                        Nationality = "nl"
                    },

                    new PlayerDetails
                    {
                        Name = "Skeanz",
                        Age = 19,
                        DOB = new DateTime(2000, 09, 25),
                        TeamsId = 10,
                        StartDate = new DateTime(2019, 12, 07),
                        Nationality = "nl"
                    },

                    new PlayerDetails
                    {
                        Name = "Selfie",
                        Age = 23,
                        DOB = new DateTime(1997, 02, 07),
                        TeamsId = 10,
                        StartDate = new DateTime(2020, 03, 04),
                        Nationality = "pl"
                    },

                    new PlayerDetails
                    {
                        Name = "Comp",
                        Age = 18,
                        DOB = new DateTime(2001, 12, 20),
                        TeamsId = 10,
                        StartDate = new DateTime(2019, 12, 07),
                        Nationality = "gr"
                    },

                    new PlayerDetails
                    {
                        Name = "Steelback",
                        Age = 23,
                        DOB = new DateTime(1996, 08, 16),
                        TeamsId = 10,
                        StartDate = new DateTime(2020, 02, 14),
                        Nationality = "nl"
                    }
                    );

            if (context.TournamentTeams.Any())
            {
                var teams = context.TournamentTeams;
                context.RemoveRange(teams);
                context.SaveChanges();
            }
            context.TournamentTeams.AddRange(
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 1
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 2
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 3
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 4
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 5
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 6
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 7
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 8
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 9
                },
                new TournamentTeam
                {
                    TournamentID = 1,
                    TeamsID = 10
                }
                 );
            context.SaveChanges();
        }
    }
}
