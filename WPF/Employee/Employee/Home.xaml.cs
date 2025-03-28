using System.Configuration;
using System.Windows;
using Employee.Pages;
namespace Employee
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        Details details;
        EmployeeCheckin checkin;
        EmployeeEdit edit;
        ReportsPage reports;
        SettingsPage settings;
        public Home()
        {
            InitializeComponent();
            details=new Details();
            edit = new EmployeeEdit();
            reports = new ReportsPage();
            settings = new SettingsPage();
            checkin = new EmployeeCheckin();
            MainFrame.Content = details;
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = details;
        }

        private void EmployeeCheckin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = checkin;
        }

        private void EmployeeEdit_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content=edit;
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.Content = reports;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = settings;
        }

    }
}
