using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

public class RestAPIClient
{
    public static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://api.bitfinex.com/v2/");

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync("trades/tBTCUSD/hist");

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseData);
            }
            else
            {
                MessageBox.Show($"Error: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Exception: {ex.Message}");
        }
    }
}