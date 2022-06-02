using System;
using System.Data.SQLite;
using System.Windows;
using Warehouse.Connection;
namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DBConn.myConn))
            {
                connection.Open();
                if (String.IsNullOrEmpty(TB_WH.Text) || String.IsNullOrEmpty(TB_Rack.Text) || String.IsNullOrEmpty(TB_Shelf.Text) || String.IsNullOrEmpty(TB_Box.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var WH = TB_WH.Text;
                    var Rack = TB_Rack.Text;
                    var Shelf = TB_Shelf.Text;
                    var Box = TB_Box.Text;

                    string query = $@"INSERT INTO Department(WH_Num,Rack_Num,Shelf_Num,Box_Num) values ('{WH}',{Rack},'{Shelf}','{Box}');";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация добавленна");
                        Window1 win1 = new Window1();
                        win1.Show();
                        Close();
                    }

                    catch (SQLiteException)
                    {

                    }
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}
