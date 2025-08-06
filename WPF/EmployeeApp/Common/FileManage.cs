using System.IO;
using System.Xml.Linq;

namespace EmployeeApp.Common
{
    public class FileManage
    {
        public string getRootpath()
        {
            string RootPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string projectpath = Path.Combine(RootPath, "EmployeeApp");
            if (!Directory.Exists(projectpath))
            {
                Directory.CreateDirectory(projectpath);
            }
            return projectpath;
        }
        public string getUserpath(string path)
        {
            
            string rootpath = getRootpath();

            //Create new folder for User
            string filepath = Path.Combine(rootpath, path);
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            string filename = Path.Combine(filepath, $"{path}.json");

            return filename;
        }

        public string Getname(string email)
        {
            string name = email.Split('@')[0];
            return name;
        }
    }
}
