using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Log
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Employee Employee { get; set; }
        public User User { get; set; }
        public DateTime CheckOutTime { get; set; }
        public bool BookStatus { get; set; }
    }
}
