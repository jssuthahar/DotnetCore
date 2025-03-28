using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Controls;
using System.Configuration;
namespace Employee
{
    /// <summary>
    /// Interaction logic for CollWindow.xaml
    /// </summary>
    public partial class CollWindow : Window
    {
        Queue q;
        List<Studnet> ostudnet;
        public CollWindow()
        {
            InitializeComponent();
            q = new Queue();
        }

        private void btnarraylist_Click(object sender, RoutedEventArgs e)
        {
            if(ostudnet is null)
            {
                ostudnet = new List<Studnet>();
            }
            
            Studnet studnet = new Studnet();
            studnet.sno =Convert.ToInt16(txtsno.Text);
            studnet.sname = txtname.Text;
            studnet.course = txtcourse.Text;
            ostudnet.Add(studnet);


            //listview Binding
            lstview.ItemsSource = null;
            lstview.ItemsSource = ostudnet;

            //List 
            lstbox.ItemsSource = null;
            lstbox.DisplayMemberPath = "sname";
            lstbox.SelectedValuePath = "sno";
            lstbox.ItemsSource = ostudnet;

        }

        private void btndrin_Click(object sender, RoutedEventArgs e)
        {
            if(q is not null && q.Count > 0)
            {
                MessageBox.Show(q.Dequeue().ToString());
                lstbox.ItemsSource = null;
                lstbox.ItemsSource = q;
                btnarraylist.Content = "Book (" + q.Count + ")";
            }
            else
            {
                MessageBox.Show("Queue is empty");
            }
             
        }
    }
    public class Studnet
    {
        public int sno { get; set; }
        public string sname { get; set; }
        public string course { get; set; }
     

    }
}
