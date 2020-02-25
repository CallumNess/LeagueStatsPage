using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeagueStatsPage.Data;
using LeagueStatsPage.Models;

namespace LeagueStatsPage.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public CreateModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PlayerDetails PlayerDetails { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PlayerDetails.Add(PlayerDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}