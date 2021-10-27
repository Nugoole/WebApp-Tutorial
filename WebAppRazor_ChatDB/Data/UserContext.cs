using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Data
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRazor_ChatDB.Model.User> User { get; set; }
    }
}
