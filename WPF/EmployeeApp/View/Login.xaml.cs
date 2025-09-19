
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
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
            try
            {

                bool isValid = isValidEmail(txtRegEmail.Text);
                if (isValid == false)
                {
                    MessageBox.Show("Email already exists");

                }
                else
                {
                    SqlConnection sql = new SqlConnection();
                    sql.ConnectionString = @"Data Source=DESKTOP-OCCP11M\SQLEXPRESS;Initial Catalog=EMPLOYEEAPP;Integrated Security=True;Encrypt=false";
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO USERS VALUES(@name,@email,@password,@age)", sql);
                    cmd.Parameters.AddWithValue("@name", txtRegName.Text);
                    cmd.Parameters.AddWithValue("@email", txtRegEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtRegPassword.Password);
                    cmd.Parameters.AddWithValue("@age", txtRegage.Text);
                    int val = cmd.ExecuteNonQuery();
                    if (val > 0)
                    {
                        MessageBox.Show("User Registered Successfully");
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
           

        }

        private bool isValidEmail(string email)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=DESKTOP-OCCP11M\SQLEXPRESS;Initial Catalog=EMPLOYEEAPP;Integrated Security=True;Encrypt=false";
            sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            cmd.CommandText = $"SELECT COUNT(*) FROM USERS WHERE Email=@email";
            cmd.Parameters.AddWithValue("@email", email);
            int count = (int)cmd.ExecuteScalar();

            bool val= count>0 ? false : true;
            return val;
            //if(count > 0)
            //{
            //    val = false;
            //}
            //else
            //{
            //    val = true;
            //}


        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection sql = new SqlConnection())
            {
                try
                {
                    sql.ConnectionString = @"Data Source=DESKTOP-OCCP11M\SQLEXPRESS;Initial Catalog=EMPLOYEEAPP;Integrated Security=True;Encrypt=false";
                    sql.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sql;
                        cmd.CommandText = "SELECT COUNT(*) FROM USERS WHERE Email=@email and Password=@password";
                        cmd.Parameters.AddWithValue("@email", txtLoginEmail.Text);
                        cmd.Parameters.AddWithValue("@password", txtLoginPassword.Password);
                        int count = (int)cmd.ExecuteScalar();

                        bool val = count > 0 ? true : false;
                        if (val == false)
                        {
                            MessageBox.Show("Invalid Credentials");
                        }
                        else
                        {
                            Home home = new Home();
                            home.Show();
                            this.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Erro Logging
                    //Firebase Crashlytics
                    //Cloud Logging
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                finally
                {
                    sql.Close();
                }

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
