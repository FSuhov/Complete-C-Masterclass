using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace RegExpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string germanTel = @"(\+49|0049)(\d{3})\/(\d+)";

            string germanTel1 = @"\+49|0049|0?1(6|7)\d/\d{8}";

            string pattern = @"\+?0{0,2}\d{3,5}\/\d+";

            string url = @"https?://.+\n";

            Regex regex = new Regex(pattern);

            string text = File.ReadAllText(@"D:\IT Step\C#\COMPLETE C# MASTERCLASS REPO\Demos\RegExpDemo\Sample.txt");

            MatchCollection matchCollection = regex.Matches(text);
            foreach(Match m in matchCollection)
            {
                
                Console.WriteLine(m);
            }
        }

        


}
}
