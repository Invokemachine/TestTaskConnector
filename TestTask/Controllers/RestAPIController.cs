using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class RestAPIController
    {
        HttpClient _httpClient;
        string Url = "https://api-pub.bitfinex.com/v2/";

        public RestAPIController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Trades>> GetTradesAsync(string value)
        {
            var response = await _httpClient.GetStringAsync($"{Url}trades/{value}/hist?limit=125&sort=-1");     //Обращение к Bitfinex API, нужно доработать (сделать параметры в ссылке вводимыми вручную)
            var tradesData = JsonConvert.DeserializeObject<List<decimal[]>>(response);      //Десериализация из формата json

            var trades = new List<Trades>();                // Преобразование данных в список объектов Trade
            foreach (var tradeData in tradesData)
            {
                var trade = new Trades
                {
                    Id = (long)tradeData[0],
                    Timestamp = DateTimeOffset.FromUnixTimeMilliseconds((long)tradeData[1]).DateTime,
                    Amount = tradeData[2],
                    Price = tradeData[3]
                };
                trades.Add(trade);
            }
            string tradesInfo = string.Join(Environment.NewLine, trades.Select(t => $"ID: {t.Id}, Время: {t.Timestamp}, Количество: {t.Amount}, Стоимость: {t.Price}"));
            MessageBox.Show(tradesInfo, "Результат запроса");
            return trades;
        }

        public async Task<Tickers> GetTickerAsync(string value)
        {
            var response = await _httpClient.GetStringAsync($"{Url}ticker/{value}");
            var tickerData = JsonConvert.DeserializeObject<decimal[]>(response);

            var tickers = new Tickers           //Преобразование данных в объект Tickers
            {
                CurrencyPair = value,
                Bid = tickerData[0],
                BidSize = tickerData[1],
                Ask = tickerData[2],
                AskSize = tickerData[3],
                LastPrice = tickerData[6],
                Volume = tickerData[7],
                High = tickerData[8],
                Low = tickerData[9]
            };

            MessageBox.Show(
                $"Пара валют: {tickers.CurrencyPair}\n" +
                $"Ставка: {tickers.Bid}\n" +
                $"Запрос: {tickers.Ask}\n" +
                $"Последняя цена: {tickers.LastPrice}\n" +
                $"Объём: {tickers.Volume}\n" +
                $"Максимальная: {tickers.High}\n" +
                $"Минимальная: {tickers.Low}",
                "Информация о тикере"
            );
            return tickers;
        }

        public async Task<List<Candles>>GetCandlesAsync(string value, int timeframe)        //Получение информации о свечах (временной промежуток задан 1 минута, поменять)
        {
            var response = await _httpClient.GetStringAsync($"{Url}candles/trade%3A{timeframe}m%3A{value}/hist");
            var candlesData = JsonConvert.DeserializeObject<List<decimal[]>>(response);

            var candles = new List<Candles>();
            foreach (var candleData in candlesData)
            {
                var candle = new Candles
                {
                    MTS = timeframe,
                    Open = candleData[1], 
                    Close = candleData[2], 
                    High = candleData[3],  
                    Low = candleData[4],   
                    Volume = candleData[5] 
                };
                candles.Add(candle);
            }
            string candlesInfo = string.Join(Environment.NewLine, candles.Select(c => $"Временной промежуток: {c.MTS}, Цена открытия: {c.Open}, " +
                $"Цена закрытия: {c.Close}, Макс. цена: {c.High}, Мин. цена: {c.Low}, Объём: {c.Volume}"));
            MessageBox.Show(candlesInfo, "Результат запроса");
            return candles;
        }
    }
}
