using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class Season
    {
        public int SeasonID { get; set; }

        public string SeasonTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Boolean IsCancelled { get; set; }

        public ICollection<Fixture> Fixtures { get; set; }

        public Tournament Tournament { get; set; }

        public int TournamentID { get; set; }
    }
}
