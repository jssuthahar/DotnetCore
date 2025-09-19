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
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
namespace EmployeeApp
{
    /// <summary>
    /// Interaction logic for SQLConnection.xaml
    /// </summary>
    public partial class ConnectionScreen : Window
    {
        public ConnectionScreen()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection();
                if (chkwindows.IsChecked == true)
                {

                    sqlConn.ConnectionString = $"Data Source={txtserver.Text};Initial Catalog={txtdatabase.Text};Integrated Security=True;Encrypt=false";


                }
                else
                {
                    sqlConn.ConnectionString = $"Data Source={txtserver.Text};Initial Catalog={txtdatabase.Text};User ID={txtusername.Text};Password={txtpassword.Password};Encrypt=false";
                }
                sqlConn.Open();
                MessageBox.Show("Connection Successful");
                QueryWindow queryWindow = new QueryWindow(sqlConn.ConnectionString);
                queryWindow.Show();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }


        }
    }
}
