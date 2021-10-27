using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebAppRazor_ChatDB.Pages
{
    public class MyRoomsModel : PageModel
    {
        private readonly Data.RoomContext _context;
        public IList<Model.Room> Rooms { get; set; }

        public MyRoomsModel(Data.RoomContext context)
        {
            _context = context;
        }

        public async void OnGetAsync()
        {
            Rooms = await _context.Room.ToListAsync();
        }
    }
}
