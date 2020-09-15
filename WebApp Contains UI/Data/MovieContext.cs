using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_Contains_UI.Models;

namespace WebApp_Contains_UI.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp_Contains_UI.Models.Movie> Movie { get; set; }
    }
}
