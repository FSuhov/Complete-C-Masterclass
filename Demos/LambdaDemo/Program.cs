using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        //Лямбда-выражение - анонимная функция, которая может быть использована для
        //создания делегатов или выражений типа дерева. Используя лямбда-выражения, можно 
        //написать локальную функцию, которая будет передаваться как аргумент или возвращать 
        //результат вызова этой функции. Особенно полезны для запросов LINQ

        //parameters=>expression/statement block

        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            Console.ReadLine();
        }

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            //предикат
            List<int> oddNumbers = list.FindAll(i => i % 2 != 0);
            oddNumbers.ForEach(i => Console.WriteLine(i));

            //более сложный пример - много действий
            oddNumbers.ForEach(i =>
            {
                Console.WriteLine("initial value " + i);
                i += 10;
                Console.WriteLine("after increment - " + i);
            });

            //с делегатом:
            math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(9));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5}));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int a)
        {
            return a * a;
        }

        public static int TimesTen(int a)
        {
            return a * 10;
        }

        
    }

    public class Number
    {
        public int n { get; set; }
    }
}
