using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;
using Xunit;

namespace UnitTests
{
    public sealed class RestAPIConnectionTest
    {
        [Fact] 
        public void TestConnectedLinkTrades()
        {
            string requiredLink = "https://api-pub.bitfinex.com/v2/trades/tBTCUSD/hist?limit=125&sort=-1";
            string Url = "https://api-pub.bitfinex.com/v2/";
            string value = "tBTCUSD";

            var connectedLink = $"{Url}trades/{value}/hist?limit=125&sort=-1";

            Assert.Equal(requiredLink, connectedLink);
        }

        [Fact]
        public void TestConnectedLinkCandles()
        {
            string requiredLink = "https://api-pub.bitfinex.com/v2/candles/trade%3A1m%3AtBTCUSD/hist";
            string Url = "https://api-pub.bitfinex.com/v2/";
            decimal timeframe = 1m;
            string value = "tBTCUSD";
            var connectedLink = $"{Url}candles/trade%3A{timeframe}m%3A{value}/hist";
           
            Assert.Equal(requiredLink, connectedLink);
        }

        [Fact]
        public void TestConnectedLinkTicker()
        {
            string requiredLink = "https://api-pub.bitfinex.com/v2/ticker/tBTCUSD";
            string Url = "https://api-pub.bitfinex.com/v2/";
            string value = "tBTCUSD";

            var connectedLink = $"{Url}ticker/{value}";

            Assert.Equal(requiredLink, connectedLink);
        }
    }
}