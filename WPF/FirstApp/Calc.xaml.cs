using System.Security.Permissions;
using System.Windows;
using System.Windows.Controls;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        #region Variable
        string oper = " ";
        string firstNumber;
        string secondNumber;
  
        #endregion

        public Calc()
        {
            InitializeComponent();
        }
        #region Event
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button btnoperator = sender as Button;

            oper = btnoperator.Content.ToString();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            
            Button buttonvalue = sender as Button;
            //TODO ::string should be empty
            if(oper == " ")
            {
                firstNumber = firstNumber + buttonvalue.Content;
                txtresult.Text = firstNumber;
            }
            else
            {
                secondNumber = secondNumber + buttonvalue.Content;
                txtresult.Text = secondNumber;
            }
           
        }



        /// <summary>
        /// Equal Operator, Arth operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt16(firstNumber);
            int second = Convert.ToInt16(secondNumber);
            int result = 0;
            if (oper == "+")
            {
                result = first + second;
            }
            else if (oper == "-")
            {
                result = first - second;
            }
            else if (oper == "*")
            {
                result = first * second;
            }
            else if (oper == "/")
            {
                result = first / second;
            }
            txtresult.Text = Convert.ToString(result);
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            oper = " ";
            firstNumber = "";
            secondNumber = "";
            txtresult.Clear();
        }

        #endregion
    }
}
