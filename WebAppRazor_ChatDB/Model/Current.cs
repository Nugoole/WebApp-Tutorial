using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazor_ChatDB.Model
{
    public static class Current
    {
        public static bool IsLoggedIn { get; internal set; }
        public static string UserID { get; set; }
        public static string UserNickName { get; set; }
        public static string RoomID { get; set; }
    }
}
