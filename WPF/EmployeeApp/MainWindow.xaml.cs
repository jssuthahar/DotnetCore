using EmployeeApp.Common;
using System.Windows;
using System.IO;
using EmployeeApp.Model;
using Newtonsoft.Json;
namespace EmployeeApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
       
    }
    private void btnlogin_Click(object sender, RoutedEventArgs e)
    {
        FileManage fileManage = new FileManage();
        string userpath= fileManage.getUserpath(txtName.Text);
        if (!File.Exists(userpath))
        {
            MessageBox.Show("User does not exist. Please register first.");

        }
        else
        {
            string output = File.ReadAllText(userpath);

            Users data = JsonConvert.DeserializeObject<Users>(output);
            if(data.Name == txtName.Text && data.Password == txtpassword.Password)
            {
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

    }
}