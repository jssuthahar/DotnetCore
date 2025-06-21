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
    /// Interaction logic for Activity.xaml
    /// </summary>
    public partial class Activity : Window
    {
        int score = 0;
        bool isStart= false;
        int noofbox = 0;
        int Team = 0;
        public Activity()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (isStart == false)
            {
                MessageBox.Show("Please click on Start button to start the game");

            }
            else
            {
                if(noofbox >2 == true)
                {
                    MessageBox.Show("You have already clicked 3 boxes, please click on Reset button to start again");
                    isStart= false;
                    noofbox = 0;
                  

                }
                else
                {
                    Random random = new Random();
                    Button button = sender as Button;
                    button.Content = random.Next(0, 99).ToString();
                    button.IsEnabled = false;
                    score = score + Convert.ToInt32(button.Content);
                    txtscore.Text = score.ToString();
                    noofbox++;
                }
                  
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            isStart = true;
            if(score > 0)
            {
                Team++;
                txtscoreboard.Text= txtscoreboard.Text + System.Environment.NewLine + "Team"+Team.ToString()+":"+ score.ToString();
            }
            noofbox = 0;
            score = 0;
        }

        private void btnstop_Click(object sender, RoutedEventArgs e)
        {
            isStart = false;
            score = 0;
            noofbox = 0;
            txtscoreboard.Text = "";
            txtscore.Text = "0";
            Team = 0;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;

            foreach (Button item in sp1.Children)
            {
                item.IsEnabled = true;
            }

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int val in num)
            //{
            //    MessageBox.Show(val.ToString());
            //}
        }
    }
}
