using System.Windows;
using Microsoft.Data.SqlClient;
namespace EmployeeApp
{
    /// <summary>
    /// Interaction logic for QueryWindow.xaml
    /// </summary>
    public partial class QueryWindow : Window
    {
        private string conn;
        public QueryWindow(string connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void btnexcute_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand(txtquery.Text,sqlConnection);
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
