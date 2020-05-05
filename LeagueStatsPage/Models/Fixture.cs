using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class Fixture
    {
        public int FixtureID { get; set; }

        public int HomeTeamID { get; set; }

        public int AwayTeamID { get; set; }

        public int HomeTeamResult { get; set; }

        public int AwayTeamResult { get; set; }

        [NotMapped]
        public string FullResult => $"{HomeTeamResult}-{AwayTeamResult}";

        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }

        [ForeignKey("HomeTeamID")]
        public Teams HomeTeam { get; set; }

        [ForeignKey("AwayTeamID")]
        public Teams AwayTeam { get; set; }

        public Season Season { get; set; }

        public int SeasonID { get; set; }

    }
}
