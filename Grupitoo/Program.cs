using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupitoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static void fileOpening(string[] args)
        {
            StreamReader sr = new StreamReader("Note1.txt") ;
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
