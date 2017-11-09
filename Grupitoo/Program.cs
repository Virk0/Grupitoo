using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Collections;
using System.IO;
=======
>>>>>>> parent of ac75b96... xd2
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupitoo
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            
        }


        //static void fileOpening(string[] args)
        //{
        //    using (StreamReader sr = new StreamReader("Note1.txt")) ;
        //    string line;
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);

        //    }



        //}
        static void WritingInFiles(string[] args)
        {
            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the My Documents path.
            string path = @"C:\Users\opilane\Documents\GitHub\Grupitoo\Grupitoo\Notes";

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(path + @"\WriteLines.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
=======
            Console.WriteLine("Lol kys xd");
>>>>>>> parent of ac75b96... xd2
        }
        static void ReadingInFiles(string[] args)
        {
                StreamReader objReader = new StreamReader("c:\\");
                string sLine = "";
                ArrayList arrText = new ArrayList();

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(sLine);
                }
                objReader.Close();

                foreach (string sOutput in arrText)
                    Console.WriteLine(sOutput);
                Console.ReadLine();
    
        }
        

    }
}
