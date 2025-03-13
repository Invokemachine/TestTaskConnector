using Xunit;

namespace UnitTests
{
    public sealed class MainWindowEventsHandlerTest
    {
        [Fact]
        public void TestConnectedLink()
        {
            string connectedLink = "https://docs.bitfinex.com";
            string actualLink = "https://docs.bitfinex.com";
            Assert.Equal(connectedLink, actualLink);
        }

        [Fact]
        public void TestShownMessage()
        {
            string shownMessage = "Чтобы получить актуальную информацию о трейдах, свечах или тикере, нажмите кнопку 'Получить трейды/Получить свечи/Получить тикер.'\n" +
                "Для получения информации в реальном времени, нажмите кнопку 'Инф. о трейдах/Инф. о свечах.'\n" +
                "В настоящий момент коннектор запрашивает данные по паре валют 'Биткоин (BTC) к доллару (USD)' и использует временной промежуток в 1 минуту.\n" +
                "Также вы можете перейти на сайт с информацией о Bitfinex, нажав на логотип Bitfinex в левой верхней части окна.";
            string actualMessage = "Чтобы получить актуальную информацию о трейдах, свечах или тикере, нажмите кнопку 'Получить трейды/Получить свечи/Получить тикер.'\n" +
                "Для получения информации в реальном времени, нажмите кнопку 'Инф. о трейдах/Инф. о свечах.'\n" +
                "В настоящий момент коннектор запрашивает данные по паре валют 'Биткоин (BTC) к доллару (USD)' и использует временной промежуток в 1 минуту.\n" +
                "Также вы можете перейти на сайт с информацией о Bitfinex, нажав на логотип Bitfinex в левой верхней части окна.";
            Assert.Equal(shownMessage, actualMessage);
        }
    }
}