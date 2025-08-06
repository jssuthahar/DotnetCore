using System.Windows;
using EmployeeApp.View.Pages;
namespace EmployeeApp.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

     

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            Student ostudent = new Student();
            MainFrame.Content = ostudent;
        }

        private void btnclient_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            MainFrame.Content = employee;
        }
        

        private void btninvoice_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice = new Invoice();
            MainFrame.Content = invoice;
        }
    }
}
