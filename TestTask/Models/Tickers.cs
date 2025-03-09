using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Tickers
    {
        public string CurrencyPair { get; set; }
        public decimal Bid { get; set; }
        public decimal BidSize { get; set; }
        public decimal Ask { get; set; }
        public decimal AskSize { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Volume { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
    }
}
