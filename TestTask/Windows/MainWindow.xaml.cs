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
    }

    private void ShowBalance_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я баланс, я работаю");
    }

    private void GetTrades_Click(object sender, RoutedEventArgs e)
    {
        RestAPIClient restAPIClient = new RestAPIClient();
        Task task = RestAPIClient.Main(null);
    }

    private void GetCandles_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я свечи, я работаю");
    }

    private void GetTicker_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я тикер, я работаю");
    }

    private void Update_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Я обновление, я работаю");
    }

}