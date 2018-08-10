using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            {
                "Первая строка", "Вторая строка", "Third line"
            };
            /*
            //Method 1:
            File.WriteAllLines(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\myFile2.txt", lines);

            //Method 2:
            string filename = Console.ReadLine();
            string input = Console.ReadLine();
            File.WriteAllText(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\"+filename + ".txt", input);
            */
            //Method 3:
            using(StreamWriter file = new StreamWriter(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\myText.txt", true))
            {
                file.WriteLine("Additional line");
            }
            /*
            string text = System.IO.File.ReadAllText(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\myFile.txt", Encoding.UTF8);
            Console.WriteLine("Text file contains:\n{0}", text);


            string[] lines = System.IO.File.ReadAllLines(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\myFile.txt", Encoding.UTF8);
            Console.WriteLine("Contents of text file = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */
            Console.ReadKey();
        }
    }
}
