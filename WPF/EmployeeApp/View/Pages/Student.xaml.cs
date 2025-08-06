using EmployeeApp.Model;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using EmployeeApp.Common;
using System.IO;
namespace EmployeeApp.View.Pages
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Page
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {

            int sid = 0;
            StudentModel student = new StudentModel();
            student.Sid = sid;
            student.Name = txtFullName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.Address = txtAddress.Text;
            student.DOB = dateDOB.SelectedDate.ToString();
            student.Course = comboCourse.SelectedItem.ToString();



            FileManage fileManage = new FileManage();
            string rootpath = fileManage.getUserpath("Student");
            List<StudentModel> liststudents = new List<StudentModel>();
            //Read Existing data
            if (File.Exists(rootpath) == true)
            {
                string existingData = File.ReadAllText(rootpath);
                liststudents = JsonConvert.DeserializeObject<List<StudentModel>>(existingData);
                student.Sid = liststudents.Count + 1; // Auto-increment Sid based on existing count
                liststudents.Add(student);
            }
            else
            {
                liststudents.Add(student);
            }

            string output = JsonConvert.SerializeObject(liststudents);
            File.WriteAllText(rootpath, output);
            MessageBox.Show("Student Registered Successfully");
            //int sid = 0;
            //StudentModel student = new StudentModel();
            //student.Sid = sid;
            //student.Name = txtFullName.Text;
            //student.Email = txtEmail.Text;
            //student.Phone = txtPhone.Text;
            //student.Address = txtAddress.Text;
            //student.DOB = dateDOB.SelectedDate.ToString();
            //student.Course = comboCourse.SelectedItem.ToString();

            //string output=JsonConvert.SerializeObject(student);

            //FileManage fileManage = new FileManage();
            //string rootpath=fileManage.getUserpath("Student");
            //File.WriteAllText(rootpath, output);
            //Model - Assign Value

        }
    }
}
