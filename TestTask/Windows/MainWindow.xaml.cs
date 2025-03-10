using Newtonsoft.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestTask.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        RestAPIClient rest = new RestAPIClient();
    }

    private void ShowBalance_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я баланс, я работаю");
    }

    private void GetTrades_Click(object sender, RoutedEventArgs e)
    {
        _ = RestAPIClient.GetTrades();
    }

    private void GetCandles_Click(object sender, RoutedEventArgs e)
    {
        _ = RestAPIClient.GetCandles();
    }

    private void GetTicker_Click(object sender, RoutedEventArgs e)
    {
        _ = RestAPIClient.GetTickers();
    }

    private void Update_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я обновление, я работаю");
    }

}