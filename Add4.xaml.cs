using System;
using System.Data.SQLite;
using System.Windows;
using Warehouse.Connection;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Add4.xaml
    /// </summary>
    public partial class Add4 : Window
    {
        public Add4()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DBConn.myConn))
            {
                connection.Open();
                if (String.IsNullOrEmpty(TB_Name.Text) || String.IsNullOrEmpty(TB_Addr.Text) || String.IsNullOrEmpty(TB_WH.Text) || String.IsNullOrEmpty(TB_Prod.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var Name = TB_Name.Text;
                    var Addr = TB_Addr.Text;
                    var WH = TB_WH.Text;
                    var Prod = TB_Prod.Text;

                    string query = $@"INSERT INTO Supplier(Name,Address,ID_WH,ID_Prod) values ('{Name}',{Addr},'{WH}','{Prod}');";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация добавленна");
                        Window4 win4 = new Window4();
                        win4.Show();
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
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }
    }
}
