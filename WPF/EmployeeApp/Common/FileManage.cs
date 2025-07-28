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
        public string getUserpath(string name)
        {
            
            string rootpath = getRootpath();

            //Create new folder for User
            string filepath = Path.Combine(rootpath, "User");
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            string filename = Path.Combine(filepath, $"{name}.json");

            return filename;
        }
    }
}
