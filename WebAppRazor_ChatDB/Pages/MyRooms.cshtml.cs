using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Pages
{
    public class MyRoomsModel : PageModel
    {
        private readonly Data.RoomContext _context;

        public IList<Model.Room> MyRooms { get; set; }

        public MyRoomsModel(Data.RoomContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            MyRooms = _context.Room.FromSqlRaw("GetMyRooms @p0", new[] { CurrentUser.UserID }).ToList();

        }
    }
}
