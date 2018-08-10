using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Полиморфизм пример 1:
            //Список может хранить любые машины. Дочерние классы могут
            //быть использованы везде, где ожидается класс Car.
            //Приведение типов не требуется, так как существует неявное приведение 
            //от дочерних к базовому классу
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            //То есть, если хотим, чтобы для базового класса вызывался метод дочернего - то override
            //если хотим, чтобы для базового класса вызывался метод базового - то в дочернем new
            Console.WriteLine("===============================");
            foreach(var car in cars)
            {
                car.ShowInfo(); //Метод, который new в дочерних классах
                car.ShowDetails();//Метод, который override в дочерних классах
            }
            Console.WriteLine("===============================");

            //Полиморфизм пример 2:
            //Поскольку метод Repair базового класса виртульный и он был переопределен
            //в дочерних классах, то будет вызываться метод дочернего:
            foreach (var car in cars)
            {
                car.Repair();
            }

            //Метод ShowInfo помечен в дочерних классах как new
            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            //Вызываются методы базового класса, так как объекты записаны в
            //переменную типа Car
            bmwZ3.ShowInfo();
            audiA3.ShowInfo();

            bmwZ3.Repair();//здесь все равно вызывается метод дочернего, так как в базовом помечен как virtual. Если он не будет вообще переопределен в дочернм, то вызовется базовый

            //Путем явного приведения типов к дочернему классу
            //вызываем метод дочернего:
            BMW carA = (BMW)bmwZ3;
            carA.ShowInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            //Вызывается метод дочернего класса, так как объект записан в 
            //переменную типа BMW
            bmwM5.ShowInfo();

            Car carB = (Car)bmwM5;
            carB.ShowInfo();


            //Has a relationship: Aggregation
            bmwZ3.SetCarIDInfo(1234, "Denis P");
            audiA3.SetCarIDInfo(1235, "Frank W");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();
        }
    }
}
