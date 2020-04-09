using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueStatsPage.Data;
using LeagueStatsPage.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeagueStatsPage.Pages.Tournaments
{
    public class IndexModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public IndexModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
            Tournaments = new List<Tournament>();
            Teams = new List<Teams>();
        }

        [BindProperty]
        public int SelectedTournament { get; set; }

        public List<Tournament> Tournaments {get; set;}
        public List<Teams> Teams { get; set; }

        public async Task OnGetAsync()
        {
            Tournaments = await _context.Tournaments.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Repopulate the Tournaments list
            Tournaments = await _context.Tournaments.ToListAsync();
            // If selected team is greater than zero then get all the Teams where their Tournament ID matches the selected Tournament
            if (SelectedTournament > 0)
            {
                Teams = await _context.TournamentTeams
                    .Where(x => x.TournamentID == SelectedTournament)
                    .Include(y => y.Teams)
                    .Select(o => o.Teams)
                    .ToListAsync();                   
            }
            return Page();
        }
    }
}
