using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppRazor_ChatDB.Data;
using WebAppRazor_ChatDB.Model;
using Microsoft.EntityFrameworkCore;

namespace WebAppRazor_ChatDB.Pages.Rooms
{
    public class CreateModel : PageModel
    {
        private readonly WebAppRazor_ChatDB.Data.RoomContext _context;

        public CreateModel(WebAppRazor_ChatDB.Data.RoomContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Room Room { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.Database.ExecuteSqlRaw("CreateRoomChat @p0, @p1, @p2", parameters: new[] { Current.UserID, Room.RoomID, Room.RoomName });

            //_context.Room.Add(Room);
            //await _context.SaveChangesAsync();

            return RedirectToPage("../MyRooms");
        }
    }
}
