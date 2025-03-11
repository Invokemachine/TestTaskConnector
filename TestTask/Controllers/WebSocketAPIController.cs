using System.Net.WebSockets;
using System.Text;
using System.Windows;

namespace TestTask.Controllers
{
    class WebSocketAPIController
    {
        private ClientWebSocket _webSocket;

        public async Task ConnectAndSubscribeAsync(string currencyPair)
        {
            _webSocket = new ClientWebSocket();
            await _webSocket.ConnectAsync(new Uri("wss://api-pub.bitfinex.com/ws/2"), CancellationToken.None);
            var subscribeMessage = $"{{\"event\":\"subscribe\",\"channel\":\"trades\",\"symbol\":\"{currencyPair}\"}}"; //Подписка на трейды
            var buffer = Encoding.UTF8.GetBytes(subscribeMessage);
            await _webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            await ReceiveMessagesAsync();
        }

        private async Task ReceiveMessagesAsync()
        {
            var buffer = new byte[1024 * 4];
            while (_webSocket.State == WebSocketState.Open)
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Text)
                {
                    var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    MessageBox.Show("Message received: " + message); 
                }
            }
        }
    }
}
