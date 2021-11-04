using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebAppRazor_ChatDB.Data;
using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Hubs
{
    public class ChatHub : Hub
    {
        private ChatContext _context;
        public ChatHub(ChatContext context)
        {
            _context = context;

        }

        public async Task SendMessage(string message)
        {
            _context.Add<Chat>(new Chat { UserID = Current.UserID, ChatDate = DateTime.Now, ChatText = message });
            await _context.SaveChangesAsync();

            var user = Current.UserNickName;
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        
    }
}
