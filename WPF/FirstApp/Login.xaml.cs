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

namespace FirstApp
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
        int count = 0;
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            //&& - all
            //|| - either one
            string username = "Admin";
            string password = "1234";
            username = "adss";
            if (username == txtusername.Text && password == pwpasword.Password)
            {

                MessageBox.Show("login Success");

            }
            else
            {
                if (count == 0)
                {
                   MessageBox.Show("1st try fails, please try again");
                    //count++;
                    count = count + 1;
                }
                else if(count ==1)
                {
                    MessageBox.Show("2nd try fails");
                    count++;
                }
                else if (count == 2)
                {
                    MessageBox.Show("3rd try fails");
                    count++;
                }
                else if (count == 3)
                {
                    MessageBox.Show("You are blocked for 5 minutes");
                   btnlogin.IsEnabled = false;
                   btnreg.IsEnabled = false;
                }

            }
        }
    }
}
