using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Database_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OleDbConnection cn;

        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\tiffa\\Downloads\\Database_TD.accdb");
        }

        private void Assetbutton_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            
            string data = "";

            while (read.Read())
            {   
                data += read[0].ToString().PadRight(10) + read[1].ToString().PadRight(10) + read[2].ToString().PadRight(10) + read[3].ToString().PadRight(10) + "\n";
            }
            cn.Close();

            MainTextBox.Text = data;
        }

        private void Employeebutton_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();

            string data = "";

            while (read.Read())
            {
                data += read[0].ToString().PadRight(10) + ' ' + read[1].ToString().PadRight(10) + ' ' + read[2].ToString() + "\n";
            }
            cn.Close();

            MainTextBox.Text = data;
        }
    }
}
