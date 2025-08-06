using EmployeeApp.Common;
using EmployeeApp.Model;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using System.Xml.Linq;

namespace EmployeeApp.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void SwitchToRegister(object sender, RoutedEventArgs e)
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            RegisterPanel.Visibility = Visibility.Visible;
        }

        private void SwitchToLogin(object sender, RoutedEventArgs e)
        {
            RegisterPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            List<Users> listusers = new List<Users>();
            //Model - Assign Value
            Users ouser = new Users();
            ouser.Name = txtRegName.Text;
            ouser.Email = txtRegEmail.Text;
            ouser.Password = txtRegPassword.Password;
            ouser.Age = Convert.ToInt32(txtRegage.Text);
            ouser.Id = 1; // Assuming Id is auto-generated or managed elsewhere

            //Root Path
            FileManage fileManage = new FileManage();
            string filename = fileManage.getUserpath("User");
            if (File.Exists(filename))
            {
                string users = File.ReadAllText(filename);
                listusers = JsonConvert.DeserializeObject<List<Users>>(users);
               
                int count=listusers.Count;
                ouser.Id = count + 1; 
                listusers.Add(ouser);
                string json = JsonConvert.SerializeObject(listusers);
                //Write json data to file
                File.WriteAllText(filename, json);
                MessageBox.Show("User Registered Successfully");


            }
            else
            {
                listusers.Add(ouser);
                string json = JsonConvert.SerializeObject(listusers);
                //Write json data to file
                File.WriteAllText(filename, json);
                MessageBox.Show("User Registered Successfully");
            }
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            FileManage fileManage = new FileManage();
            string userpath = fileManage.getUserpath("User");
            if(File.Exists(userpath) == false)
            {
                MessageBox.Show("User not registered");
                return;
            }
            else
            {
                string output = File.ReadAllText(userpath);
                List<Users> data = JsonConvert.DeserializeObject<List<Users>>(output);

                var user= from x in data
                          where x.Email==txtLoginEmail.Text && x.Password==txtLoginPassword.Password
                          select x;
                if(user.Count() >0)
                {
                    Home home = new Home();
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }



            //if (data.Email == txtLoginEmail.Text && data.Password == txtLoginPassword.Password)
            //{

            //    Home home = new Home();
            //    home.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Credentials");
            //}


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            txtLoginEmail.Text = txtLoginEmail.Text + "@jsdevbrains.com";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            txtLoginEmail.Text = txtLoginEmail.Text + "@gmail.com";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            txtLoginEmail.Text = txtLoginEmail.Text + "@hotmail.com";
        }
    }
}
