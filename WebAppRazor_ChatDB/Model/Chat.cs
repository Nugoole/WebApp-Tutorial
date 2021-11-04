using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRazor_ChatDB.Model
{
    public class Chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ChatID { get; set; }
        public string UserID { get; set; }
        public DateTime ChatDate { get; set; }
        public string ChatText { get; set; }
    }
}
