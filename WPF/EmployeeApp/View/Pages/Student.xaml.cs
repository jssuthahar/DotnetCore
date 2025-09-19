
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using EmployeeApp.Model;
using EmployeeApp.BL;
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

          string Connection = "Data Source=DESKTOP-OCCP11M\\SQLEXPRESS;Initial Catalog=EMPLOYEEAPP;Integrated Security=True;Encrypt=false";

           SqlConnection sql = new SqlConnection();
            sql.ConnectionString = Connection;
            sql.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            cmd.CommandText = "SELECT CID,CNAME FROM COURSE";
            SqlDataAdapter oda = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            oda.Fill(dataSet,"Course");

            comboCourse.DisplayMemberPath= "CNAME";
            comboCourse.SelectedValuePath= "CID";
            comboCourse.ItemsSource = dataSet.Tables["Course"].DefaultView;
            sql.Close();


        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            EmployeeApp.Model.Student student = new EmployeeApp.Model.Student();
            Register or = new Register();
            student.Sname = txtFullName.Text;
            student.Email = txtEmail.Text;
            student.Phone = Convert.ToInt16(txtPhone.Text);
            student.Dob = dateDOB.SelectedDate?.ToString("yyyy-MM-dd");
            student.Cid = Convert.ToInt16(comboCourse.SelectedValue);
            student.Address = txtAddress.Text;
            int result = or.RegisterCourse(student);
            //try
            //{



            //        SqlConnection sql = new SqlConnection();
            //        sql.ConnectionString = @"Data Source=DESKTOP-OCCP11M\SQLEXPRESS;Initial Catalog=EMPLOYEEAPP;Integrated Security=True;Encrypt=false";
            //        sql.Open();
            //        SqlCommand cmd = new SqlCommand("INSERT INTO StudCourse VALUES(@sname,@email,@phone,@dob,@cid,@address)", sql);
            //        cmd.Parameters.AddWithValue("@sname", txtFullName.Text);
            //        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            //        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            //        cmd.Parameters.AddWithValue("@dob", dateDOB.SelectedDate);
            //        cmd.Parameters.AddWithValue("@cid", comboCourse.SelectedValue);
            //        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            //        int val = cmd.ExecuteNonQuery();
            //        if (val > 0)
            //        {
            //            MessageBox.Show("Student Registered Successfully");
            //        }

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("SQL Error: " + ex.Message);
            //}


        }
    }
}
