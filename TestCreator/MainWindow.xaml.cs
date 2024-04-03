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

namespace TestCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KeyTbx.IsEnabled = false;
        }

        public string secretKey = "1337";

        private void StartButton(object sender, RoutedEventArgs e)
        {
            KeyTbx.IsEnabled = false;
            Testing testing = new Testing();
            testing.Show();
            Close();
        }

        private void CreateButton(object sender, RoutedEventArgs e)
        {
            KeyTbx.IsEnabled = true;

            if (KeyTbx.Text == secretKey)
            {
                Creating creating = new Creating();
                creating.Show();
                Close();
            }
        }

        private void KeyTbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}