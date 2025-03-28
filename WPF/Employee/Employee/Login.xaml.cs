using System.Windows;
using System.IO;
using System.Collections;
using Employee.Model;
using Newtonsoft.Json;
namespace Employee
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string rootPath = "";
        public Login()
        {
            InitializeComponent();
            rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string project = Path.Combine(rootPath, "Employee");
            if(Directory.Exists(project)== false)
            {
                Directory.CreateDirectory(project);
            }
            rootPath = project;
        }

     
        private void btnreg_Click(object sender, RoutedEventArgs e)
        {

          
            Emp emp = new Emp();
            emp.UserName = txtNewUsername.Text;
            emp.Password = txtNewPassword.Password;
            emp.Email = txtEmail.Text;
           
            string json= JsonConvert.SerializeObject(emp);
            string filename = Path.Combine(rootPath, txtNewUsername.Text + ".json");
            File.WriteAllText(filename, json);

        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            string userPath = Path.Combine(rootPath, txtUsername.Text + ".json");
            if (File.Exists(userPath))
            {
                string data = File.ReadAllText(userPath);
                Emp empdata = JsonConvert.DeserializeObject<Emp>(data);


                if (empdata.UserName.ToLower() == txtUsername.Text.ToLower() && empdata.Password == txtPassword.Password)
                {
                    Home ohome = new Home();
                    ohome.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed");

                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
