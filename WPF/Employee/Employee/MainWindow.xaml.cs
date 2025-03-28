using System.Windows;
using System.IO;
namespace Employee;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btncreate_Click(object sender, RoutedEventArgs e)
    {
        string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //string folderpath = temppath + "//Studnet"+"//Employee;
        string folderpath = Path.Combine(AppData, "Employee");
        if (!Directory.Exists(folderpath))
        {
            Directory.CreateDirectory(folderpath);
        }
        //  string filename = folderpath + "//Alagu.txt";
        string filename = Path.Combine(folderpath, "Alagu.txt");
        if (!File.Exists(filename))
        {
            File.Create(filename);
        }
        //Create
       
    }

    private void btnwrite_Click(object sender, RoutedEventArgs e)
    {
        //File write
        //Create & Write
        //Replace
        File.WriteAllText(@"C:\JS11PM\Abisha.txt", "Welcome to jsquare");
    }

    private void btndelete_Click(object sender, RoutedEventArgs e)
    {
        if(File.Exists(@"C:\JS11PM\Abisha.txt") ==true)
        {
            File.Delete(@"C:\JS11PM\Abisha.txt");
        }
        else
        {
            MessageBox.Show("File not avilbale ");
        }
      
    }

    private void btnread_Click(object sender, RoutedEventArgs e)
    {
        if (File.Exists(@"C:\JS11PM\Abisha.txt") == true)
        {
            string value = File.ReadAllText(@"C:\JS11PM\Abisha.txt");
            MessageBox.Show(value);
        }
        else
        {
            MessageBox.Show("File not avilbale ");
        }
    }

    private void btnfolder_Click(object sender, RoutedEventArgs e)
    {
        Directory.CreateDirectory(@"C:\JS11PM\Stud");
    }

    private void btndeletefolder_Click(object sender, RoutedEventArgs e)
    {
        if(Directory.Exists(@"C:\JS11PM\Stud"))
        {
            Directory.Delete(@"C:\JS11PM\Stud");
        }    
    }

    private void btnlistfiles_Click(object sender, RoutedEventArgs e)
    {
      string[] listfiles=  Directory.GetFiles(@"C:\JSDemo");
        FileInfo ofile = new FileInfo(@"C:\JS11PM\Abisha.txt");
        MessageBox.Show(ofile.CreationTime.ToString());
       
    }

    private void btnfolderlist_Click(object sender, RoutedEventArgs e)
    {
        string[] listfolder= Directory.GetDirectories(@"C:\JSDemo");
        DirectoryInfo odirect = new DirectoryInfo(@"C:\JSDemo");
        MessageBox.Show(odirect.CreationTime.ToString());
    }
}