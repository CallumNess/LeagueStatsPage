using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueStatsPage.Models
{
    public class PlayerDetails
    {
        public int PlayerDetailsID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }

        public bool IsActive { get; set; }

        public int TeamsId { get; set; }
      
        public Teams Team { get; set; }
    }
}
