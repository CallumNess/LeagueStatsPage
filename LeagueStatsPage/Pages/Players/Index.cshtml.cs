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
        }

        public IList<PlayerDetails> PlayerDetails { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> teamQuery = from t in _context.PlayerDetails
                                            orderby t.Team
                                            select t.Team;
     
            var name = from n in _context.PlayerDetails
                         select n;

            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                PlayerDetails = await _context.PlayerDetails.Where(x => x.Name.Contains(SearchString)).ToListAsync();
            }
            else
            {
                PlayerDetails = await _context.PlayerDetails.ToListAsync();
            }
        }

        public IList<PlayerDetails> name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Names { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PlayerName { get; set; }

    }
}
