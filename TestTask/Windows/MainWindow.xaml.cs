using System.Windows;
using TestTask.Services;

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
        WebSocketAPIClient webSocket = new WebSocketAPIClient();
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

    private void UpdatedTrades_Click(object sender, RoutedEventArgs e)
    {
        WebSocketAPIClient.ConnectToTrades();
    }

    private void UpdatedCandles_Click(object sender, RoutedEventArgs e)
    {

    }
}