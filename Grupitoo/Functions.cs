using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupitoo
{
    class NoteFunctions
    {
        static void creating_files()
        {
            string path = @"C:\grupitoo";
            if (Directory.Exists(path))
            {
                File.AppendAllText(path + "\\Test.txt", "The first line");
            }
            else
            {
                Directory.CreateDirectory(path);
                File.AppendAllText(path + "\\Test.txt", "The first line");
            }
        }
    }
}
