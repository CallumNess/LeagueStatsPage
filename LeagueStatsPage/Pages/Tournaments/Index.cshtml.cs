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

        public List<Tournament> Tournaments {get; set;}
        public List<Teams> Teams { get; set; }

        public async Task OnGetAsync(int? tournamentId)
        {
            Tournaments = await _context.Tournaments.ToListAsync();

            if (tournamentId != null)
            {
                Teams = await _context.TournamentTeams
                    .Where(x => x.TournamentID == tournamentId)
                    .Include(y => y.Teams)
                    .Select(o => o.Teams)
                    .ToListAsync();
            }
        }
    }
}
