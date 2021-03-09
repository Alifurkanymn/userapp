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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection Connect = new SQLiteConnection("Data Source=C:/PersonsDB.db;Version=3;");
            Connect.Open();

            string sql = "INSERT INTO User(Name,SurName,PhoneNumber,Gender) values(@Name,@SurName,@PhoneNumber,@Gender)";
            SQLiteCommand komut = new SQLiteCommand(sql,Connect);
           // komut.Parameters.AddWithValue("@Name",txtName.Text);
           // komut.Parameters.AddWithValue("@Name", txtSurName.Text);
           // komut.Parameters.AddWithValue("@Name", txtPhoneNumber.Text);
           // komut.Parameters.AddWithValue("@Name", txtName.Text);
           // komut.Parameters.AddWithValue("@Name", txtName.Text);
        }
    }
}
