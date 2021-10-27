using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazor_ChatDB.Model
{
    public class Room
    {
        [Key]
        public string RoomID { get; private set; }
        public string RoomName { get; set; }

        public Room()
        {
            RoomID = Guid.NewGuid().ToString();
        }
    }
}