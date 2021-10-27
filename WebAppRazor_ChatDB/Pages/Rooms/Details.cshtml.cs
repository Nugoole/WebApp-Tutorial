using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppRazor_ChatDB.Data;
using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppRazor_ChatDB.Data.RoomContext _context;

        public DetailsModel(WebAppRazor_ChatDB.Data.RoomContext context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Room.FirstOrDefaultAsync(m => m.RoomID == id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
