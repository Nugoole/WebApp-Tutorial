using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp_Contains_UI.Data;
using WebApp_Contains_UI.Models;

namespace WebApp_Contains_UI.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebApp_Contains_UI.Data.MovieContext _context;

        public IndexModel(WebApp_Contains_UI.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
