using EmployeeApp.Common;
using System.IO;
using System.Windows.Controls;
using Newtonsoft.Json;
using EmployeeApp.Model;
namespace EmployeeApp.View.Pages
{
    /// <summary>
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : Page
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void cmbInvoiceFor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if(cmbInvoiceFor.SelectedIndex ==0)
            {
                FileManage fileManage = new FileManage();
                string rootpath = fileManage.getUserpath("Student");
                string data=File.ReadAllText(rootpath);
                List<StudentModel> liststudentmodel=JsonConvert.DeserializeObject<List<StudentModel>>(data);
                cmbName.DisplayMemberPath = "Name";
                cmbName.SelectedValuePath = "Sid";
                cmbName.ItemsSource = liststudentmodel;
            }
            else
            {

            }
        }
    }
}
