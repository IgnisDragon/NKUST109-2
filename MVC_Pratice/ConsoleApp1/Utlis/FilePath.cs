using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utlis
{
    public class FilePath
    {
        public FilePath() { }
        public static string getFilePath(string file)
        {
            string path = @"..\ConsoleApp1\Data\" + file;

            return path;
        }
    }
}
