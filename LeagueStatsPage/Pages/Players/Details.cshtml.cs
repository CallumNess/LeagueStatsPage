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
    public class DetailsModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public DetailsModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
        }

        public PlayerDetails PlayerDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlayerDetails = await _context.PlayerDetails.FirstOrDefaultAsync(m => m.PlayerDetailsID == id);

            if (PlayerDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
