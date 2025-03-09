using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Trades
    {
        public long Id { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
}
