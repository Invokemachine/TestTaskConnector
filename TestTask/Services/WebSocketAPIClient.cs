using System.Windows;
using TestTask.Controllers;

namespace TestTask.Services
{
    public class WebSocketAPIClient
    {
        static WebSocketAPIController _webSocketController;

        public static void ConnectToTrades()
        {
            try
            {
                var webSocketClient = new WebSocketAPIController();
                webSocketClient.TradesConnectAndSubscribeAsync("tBTCUSD");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        public static void ConnectToCandles()
        {
            try
            {
                var webSocketClient = new WebSocketAPIController();
                webSocketClient.CandlesConnectAndSubscribeAsync("tBTCUSD", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
