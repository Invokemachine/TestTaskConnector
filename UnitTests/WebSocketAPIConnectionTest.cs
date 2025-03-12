using Xunit;

namespace UnitTests
{
    public sealed class WebSocketAPIConnectionTest
    {
        [Fact]
        public void TestMessagePathTrades()
        {
            string originalSubscribePath = "{\"event\":\"subscribe\",\"channel\":\"trades\",\"symbol\":\"tBTCUSD\"}";
            string currencyPair = "tBTCUSD";
            string requiredNameForPath = "trades";
            var subscribePath = $"{{\"event\":\"subscribe\",\"channel\":\"{requiredNameForPath}\",\"symbol\":\"{currencyPair}\"}}";

            Assert.Equal(originalSubscribePath, subscribePath);
        }

        [Fact]
        public void TestMessagePathCandles()
        {
            string originalSubscribePath = "{\"event\":\"subscribe\",\"channel\":\"candles\",\"symbol\":\"tBTCUSD\"}";
            string currencyPair = "tBTCUSD";
            string requiredNameForPath = "candles";
            var subscribePath = $"{{\"event\":\"subscribe\",\"channel\":\"{requiredNameForPath}\",\"symbol\":\"{currencyPair}\"}}";

            Assert.Equal(originalSubscribePath, subscribePath);
        }
    }
}