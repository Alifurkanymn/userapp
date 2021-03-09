using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        class customerDataGrid
        {
            public static DataView ItemsSource { get; internal set; }
        }


        public void list()
        {
            SQLiteConnection Connect = new SQLiteConnection("Data Source=C:/PersonsDB.db;Version=3;");
            Connect.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM User", Connect);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            customerDataGrid.ItemsSource = Table.DefaultView;
            Connect.Close();

        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 addwindow = new Window1();
            addwindow.Show();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            list();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            list();
        }
    }
}
