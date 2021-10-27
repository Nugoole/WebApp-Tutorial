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
    public class DetailsModel : PageModel
    {
        private readonly WebAppRazor_ChatDB.Data.UserContext _context;

        public DetailsModel(WebAppRazor_ChatDB.Data.UserContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
