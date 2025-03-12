using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Currency
    {
        public string CurrencyName { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountInBTC { get; set; }
        public decimal AmountInXPR { get; set; }
        public decimal AmountInXMR { get; set; }
        public decimal AmountInDASH { get; set; }
        public decimal AmountInUSD { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountInUSD = 126821.4m;
    }
}
