using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(index);

            list.RemoveAt(index);

            list.ForEach(i => { Console.Write(i); Console.Write(", "); });

            //======================================================

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("one");
            arrayList.Add(2.59);
            arrayList.Add(new Number { n = 4 });

            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }

        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
