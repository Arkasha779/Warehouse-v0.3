using System.Windows;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
            Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            Close();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            Window5 win5 = new Window5();
            win5.Show();
            Close();
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            Help win6 = new Help();
            win6.Show();
            Close();
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            Window7 win7 = new Window7();
            win7.Show();
            Close();
        }
    }
}
