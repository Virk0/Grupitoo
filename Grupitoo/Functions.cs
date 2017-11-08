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
        static string Path = "Notes.txt";
        public static void CreateText()
        {
            File.Create(Path);
        }

        
    }
}
