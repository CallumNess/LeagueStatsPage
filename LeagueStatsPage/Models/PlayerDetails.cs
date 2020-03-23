using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Age { get; set; }
       
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }

        public bool IsActive { get; set; }
    }
}
