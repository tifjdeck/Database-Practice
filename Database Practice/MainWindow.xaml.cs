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
        public MainWindow()
        {
            InitializeComponent();
            GCNotificationStatus = new OleDbConnection(Provider = Microsoft.ACE.OLEDB.12.0; Data Source =| DataDirectory |\Database_TD.accdb);
        }

        private void Assetbutton_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection cn;
            string query = "select * from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            
            string data = "";

            while (read.Read())
            {
                data += read[0].ToString() + "\n";
            }
        }
    }
}
