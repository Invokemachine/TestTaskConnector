using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class PortfolioController
    {
        public static Portfolio InitializeCurrencies()
        {
            var portfolio = new Portfolio
            {
                Currencies = new List<Currency>
                {
                    new Currency {CurrencyName = "BTC", Amount = 1},
                    new Currency {CurrencyName = "XPR", Amount = 15000},
                    new Currency {CurrencyName = "XMR", Amount = 50},
                    new Currency {CurrencyName = "DASH", Amount = 30}
                }
            };

            decimal USDtoBTC = 82641.00m;       //Соотношение криптовалют к доллару, оно необходимо для упрощенной конвертации между валютами
            decimal USDtoXPR = 2.21m;
            decimal USDtoXMR = 207.45m;
            decimal USDtoDASH = 21.93m;

            foreach (var currency in portfolio.Currencies)
            {
                switch (currency.CurrencyName)
                {
                    case "BTC":
                        currency.AmountInBTC = currency.Amount;
                        currency.AmountInXPR = currency.Amount * USDtoBTC / USDtoXPR;
                        currency.AmountInXMR = currency.Amount * USDtoBTC / USDtoXMR;
                        currency.AmountInDASH = currency.Amount * USDtoBTC / USDtoDASH;
                        currency.AmountInUSD = currency.Amount * USDtoBTC;
                        currency.TotalAmount = currency.TotalAmountInUSD / USDtoBTC;
                        break;
                    case "XPR":
                        currency.AmountInBTC = currency.Amount * USDtoXPR / USDtoBTC;
                        currency.AmountInXPR = currency.Amount;
                        currency.AmountInXMR = currency.Amount * USDtoXPR / USDtoXMR; 
                        currency.AmountInDASH = currency.Amount * USDtoXPR / USDtoDASH;
                        currency.AmountInUSD = currency.Amount * USDtoXPR;
                        currency.TotalAmount = currency.TotalAmountInUSD / USDtoXPR;
                        break;
                    case "XMR":
                        currency.AmountInBTC = currency.Amount * USDtoXMR / USDtoBTC;
                        currency.AmountInXPR = currency.Amount * USDtoXMR / USDtoXPR;
                        currency.AmountInXMR = currency.Amount;
                        currency.AmountInDASH = currency.Amount * USDtoXMR / USDtoDASH;
                        currency.AmountInUSD = currency.Amount * USDtoXMR;
                        currency.TotalAmount = currency.TotalAmountInUSD / USDtoXMR;
                        break;
                    case "DASH":
                        currency.AmountInBTC = currency.Amount * USDtoDASH / USDtoBTC;
                        currency.AmountInXPR = currency.Amount * USDtoDASH / USDtoXPR;
                        currency.AmountInXMR = currency.Amount * USDtoDASH / USDtoXMR; 
                        currency.AmountInDASH = currency.Amount;
                        currency.AmountInUSD = currency.Amount * USDtoDASH;
                        currency.TotalAmount = currency.TotalAmountInUSD / USDtoDASH;
                        break;
                }
            }
            return portfolio;
        }
    }
}
