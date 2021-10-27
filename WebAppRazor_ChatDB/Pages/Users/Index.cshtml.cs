using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppRazor_ChatDB.Data;
using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly WebAppRazor_ChatDB.Data.UserContext _context;

        public IndexModel(WebAppRazor_ChatDB.Data.UserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
