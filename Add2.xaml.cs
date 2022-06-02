using System;
using System.Data.SQLite;
using System.Windows;
using Warehouse.Connection;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Add2.xaml
    /// </summary>
    public partial class Add2 : Window
    {
        public Add2()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DBConn.myConn))
            {
                connection.Open();
                if (String.IsNullOrEmpty(TB_Dep.Text) || String.IsNullOrEmpty(TB_Name.Text) || String.IsNullOrEmpty(TB_Prod.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var Dep = TB_Dep.Text;
                    var Name = TB_Name.Text;
                    var Prod = TB_Prod.Text;

                    string query = $@"INSERT INTO Warehouse(ID_Depar,Name,ID_Prod) values ('{Dep}',{Name},'{Prod}');";
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Информация добавленна");
                        Window2 win2 = new Window2();
                        win2.Show();
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
            Window2 win2 = new Window2();
            win2.Show();
            Close();
        }
    }
}
