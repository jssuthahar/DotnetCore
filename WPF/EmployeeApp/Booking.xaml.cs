using EmployeeApp.Model;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using EmployeeApp.Common;

namespace EmployeeApp
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        public Booking()
        {
            InitializeComponent();
          

        }
        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            //Model - Assign Value
            Users ouser = new Users();
            ouser.Name=txtName.Text;
            ouser.Email = txtemail.Text;
            ouser.Password = txtpassword.Password;
            ouser.Age =  Convert.ToInt32(txtage.Text);

            //Root Path
            FileManage fileManage = new FileManage();
            string filename= fileManage.getUserpath(ouser.Name);
            if (File.Exists(filename))
            {
                MessageBox.Show("User Already Exists");

            }
            else
            {
                //string json data 
                string json = JsonConvert.SerializeObject(ouser);
                //Write json data to file
                File.WriteAllText(filename, json);
                MessageBox.Show("User Registered Successfully");
            }
            
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
