using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestTask.Services
{
    class WebSocketAPIClient
    {
        public async Task ConnectAsync(string url, CancellationToken cancellationToken)
        {
            try
            {
                using (ClientWebSocket clientWebSocket = new ClientWebSocket())
                {
                    Uri serverUri = new Uri("https://api-pub.bitfinex.com/");
                    await clientWebSocket.ConnectAsync(serverUri, CancellationToken.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
