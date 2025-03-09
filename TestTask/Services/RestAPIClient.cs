using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using TestTask.Controllers;
using TestTask.Models;
using TestTask.Windows;

public class RestAPIClient
{
    public static async Task GetTrades()
    {
        HttpClient httpClient = new HttpClient();
        RestAPIController restAPIController = new RestAPIController(httpClient);

        try
        {
            var trades = await restAPIController.GetTradesAsync("tBTCUSD");         //Вызов метода из контроллера, позже нужно добавить возможность изменять этот параметр пользователю
            string tradesInfo = string.Join(Environment.NewLine, trades.Select(t =>$"ID: {t.Id}, Время: {t.Timestamp}, Количество: {t.Amount}, Стоимость: {t.Price}"));
            MessageBox.Show(tradesInfo, "Результат запроса");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Exception: {ex.Message}", "Ошибка");
        }
    }

    public static async Task GetTickers()
    {
        HttpClient httpClient = new HttpClient();
        RestAPIController restAPIController = new RestAPIController(httpClient);

        try
        {
            var tickers = await restAPIController.GetTickerAsync("tBTCUSD");         //Вызов метода из контроллера, позже нужно добавить возможность изменять этот параметр пользователю
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Exception: {ex.Message}", "Ошибка");
        }
    }
}