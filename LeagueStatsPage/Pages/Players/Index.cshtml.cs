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

namespace LeagueStatsPage.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueStatsPage.Data.LeagueStatsPageContext _context;

        public IndexModel(LeagueStatsPage.Data.LeagueStatsPageContext context)
        {
            _context = context;
            Teams = new List<Teams>();
        }

        public IList<PlayerDetails> PlayerDetails { get;set; }

        [BindProperty]
        public int SelectedTeam { get; set; }

        public List<Teams> Teams { get; set; }

        public async Task OnGetAsync()
        {
            Teams = await _context.Teams.ToListAsync();
            PlayerDetails = await _context.PlayerDetails.Include(x => x.Team).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Repopulate the teams list
            Teams = await _context.Teams.ToListAsync();
            // If selected team is greater than zero then get all the players where their team id matches the selected team
            if (SelectedTeam > 0)
            {
                PlayerDetails = await _context.PlayerDetails
                    .Where(x => x.TeamsId == SelectedTeam)
                    .Include(x => x.Team)
                    .ToListAsync();
            }
            return Page();
        }
    }
}
