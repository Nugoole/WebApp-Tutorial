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
    public class DeleteModel : PageModel
    {
        private readonly WebAppRazor_ChatDB.Data.RoomContext _context;

        public DeleteModel(WebAppRazor_ChatDB.Data.RoomContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Room.FindAsync(id);

            if (Room != null)
            {
                _context.Database.ExecuteSqlRaw("GetOutFromRoom @p0, @p1", parameters: new[] { Current.UserID, Room.RoomID });
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/MyRooms");
        }
    }
}
