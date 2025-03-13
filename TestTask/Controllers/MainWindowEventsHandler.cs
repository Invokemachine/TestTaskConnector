using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestTask.Controllers
{
    public class MainWindowEventsHandler
    {
        public static void OpenLink()
        {
            Process.Start(new ProcessStartInfo("https://docs.bitfinex.com") { UseShellExecute = true });
        }
        public static void OpenInformation()
        {
            MessageBox.Show("Чтобы получить актуальную информацию о трейдах, свечах или тикере, нажмите кнопку 'Получить трейды/Получить свечи/Получить тикер.'\n" +
                "Для получения информации в реальном времени, нажмите кнопку 'Инф. о трейдах/Инф. о свечах.'\n" +
                "В настоящий момент коннектор запрашивает данные по паре валют 'Биткоин (BTC) к доллару (USD)' и использует временной промежуток в 1 минуту.\n" +
                "Также вы можете перейти на сайт с информацией о Bitfinex, нажав на логотип Bitfinex в левой верхней части окна.", "Информация");
        }
    }
}
