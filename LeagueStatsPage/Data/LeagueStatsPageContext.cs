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

        public LeagueStatsPageContext()
        {
            
        }
        public LeagueStatsPageContext(DbContextOptions<LeagueStatsPageContext> options) : base(options)
        {

        }
    }
}
