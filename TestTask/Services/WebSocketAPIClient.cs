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
                webSocketClient.ConnectAndSubscribeAsync("tBTCUSD");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
