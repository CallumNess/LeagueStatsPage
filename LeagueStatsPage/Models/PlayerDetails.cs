using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class PlayerDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

        [DataType(DataType.Date)]
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
