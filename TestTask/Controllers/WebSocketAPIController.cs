using System.Net.WebSockets;
using System.Text;
using System.Windows;

namespace TestTask.Controllers
{
    class WebSocketAPIController
    {
        private ClientWebSocket _webSocket;
        private string MessageOrigin;

        public async Task TradesConnectAndSubscribeAsync(string currencyPair)
        {
            _webSocket = new ClientWebSocket();
            await _webSocket.ConnectAsync(new Uri("wss://api-pub.bitfinex.com/ws/2"), CancellationToken.None); //Подписка на трейды
            var subscribeMessage = $"{{\"event\":\"subscribe\",\"channel\":\"trades\",\"symbol\":\"{currencyPair}\"}}";
            var buffer = Encoding.UTF8.GetBytes(subscribeMessage);
            await _webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            MessageOrigin = "Trades";
            await ReceiveMessagesAsync();
        }

        public async Task CandlesConnectAndSubscribeAsync(string currencyPair, int timeFrame)
        {
            _webSocket = new ClientWebSocket();
            await _webSocket.ConnectAsync(new Uri("wss://api-pub.bitfinex.com/ws/2"), CancellationToken.None);
            var subscribeMessage = $"{{\"event\":\"subscribe\",\"channel\":\"candles\",\"key\":\"trade:{timeFrame}:{currencyPair}\"}}";
            var buffer = Encoding.UTF8.GetBytes(subscribeMessage);
            await _webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            MessageOrigin = "Candles";
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
                    if (MessageOrigin == "Trades")
                        MessageBox.Show("Обновление трейдов: " + message);
                    else if (MessageOrigin == "Candles")
                        MessageBox.Show("Обновление свечей: " + message);
                    else
                        MessageBox.Show("Ошибка!");
                }
            }
        }
    }
}
