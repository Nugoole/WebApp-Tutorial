using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazor_ChatDB.Model
{
    public class Chat
    {
        public string UserID { get; set; }
        public string ChatDate { get; set; }
        public string ChatText { get; set; }
    }
}
