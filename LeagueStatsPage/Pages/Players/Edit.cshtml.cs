using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueStatsPage.Data;
using LeagueStatsPage.Models;

namespace LeagueStatsPage.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public EditModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PlayerDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerDetailsExists(PlayerDetails.PlayerDetailsID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlayerDetailsExists(int id)
        {
            return _context.PlayerDetails.Any(e => e.PlayerDetailsID == id);
        }
    }
}
