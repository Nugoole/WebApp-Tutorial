using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR.Client;

using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Pages
{
    public class ChatRoomModel : PageModel
    {
        private List<string> messages = new List<string>();
        private string userInput;
        private string messageInput;

        

        public ChatRoomModel()
        {
            
        }

        public async void OnGetAsync(string id)
        {
            Current.RoomID = id;
        }
    }
}
