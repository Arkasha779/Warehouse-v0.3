using System.Windows;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
        }

        private void bb_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }

        private void bn_Click(object sender, RoutedEventArgs e)
        {
            Help2 win1 = new Help2();
            win1.Show();
            Close();
        }
    }
}
