using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebAppRazor_ChatDB.Data;
using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Pages
{
    public class IndexModel : PageModel
    {

        private readonly UserContext _context;

        [BindProperty]
        public Model.User User { get; set; }

        public IndexModel(UserContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
                return NotFound();

            var foundUser = _context.User.FindAsync(id);

            if (foundUser.Result != null)
            {
                CurrentUser.IsLoggedIn = true;
                CurrentUser.UserID = foundUser.Result.UserID;
                CurrentUser.UserNickName = foundUser.Result.UserNickName;
                return RedirectToPage("MyRooms");
            }

            return RedirectToPage("./Error");
        }
    }
}
