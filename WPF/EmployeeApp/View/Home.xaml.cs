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

        private void Studmenu_Click(object sender, RoutedEventArgs e)
        {
            Student ostudent=new Student();
            MainFrame.Content = ostudent;
        }

        private void ClientMenu_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            MainFrame.Content = employee;
        }

        private void Invoicemenu_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice = new Invoice();
            MainFrame.Content = invoice;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoForward)
            {
                MainFrame.GoForward();
            }
        }
    }
}
