using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebAppRazor_ChatDB.Model;

namespace WebAppRazor_ChatDB.Data
{
    public class ChatContext : DbContext
    {

        public ChatContext(DbContextOptions<ChatContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Chat>().ToTable($"Chat_{Current.RoomID}").Property(f => f.ChatID).ValueGeneratedOnAdd();
        }
    }
}
