using System.Windows;


namespace FirstApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnclick_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtemail.Text)==false)
        {
            string[] listemail = txtemail.Text.Split(';');
            int count = listemail.Length;
            if (count > 0 == true)
            {
                for (int i = 0; i < count; i++)
                {
                  //  MessageBox.Show(listemail[i]);
                  Console.WriteLine(listemail[i]);
                  Console.Write("ads");
                }
            }
            else
            {
                MessageBox.Show("Please enter atleast one email");
            }
        }


        //string[] names = { "Hajesh", "Bharath", "Gokul","Vimal" };
        //int[] numbers = { 1, 2, 3, 4, 5 };

        //int count = names.Length;
        //for (int i = 0; i < count; i++)
        //{
        //    MessageBox.Show(names[i]);
        //}

        //int startvalue=Convert.ToInt32(txtstart.Text);
        //int endvalue=Convert.ToInt32(txtend.Text);
        //string numbersstring="";
        //for (int i = startvalue; i < endvalue; i = i + 1)
        //{
        //    numbersstring = numbersstring + i.ToString() + System.Environment.NewLine;
        //}

        //MessageBox.Show(numbersstring.ToString());

        //int j = 0;
        //for(; j<5; )
        //{

        //    MessageBox.Show("Hello World " + j);
        //    j++;
        //}

        //int k = 0;
        //for (; ;)
        //{
        //    if(k > 5 )
        //    {
        //        break;
        //    }
        //    MessageBox.Show("Hello World " + k);
        //    k++;
        //}



    }
}


