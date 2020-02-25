using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueStatsPage.Data;
using LeagueStatsPage.Models;

namespace LeagueStatsPage.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public IndexModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
        }

        public IList<PlayerDetails> PlayerDetails { get;set; }

        public async Task OnGetAsync()
        {
            PlayerDetails = await _context.PlayerDetails.ToListAsync();
        }
    }
}
