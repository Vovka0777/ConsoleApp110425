using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(55.75,37.61,1000000,800,2020,10000,200);
            Car car = new Car(55.75,37.61,20000,180,2015,5);
            Ship ship = new Ship(55.75,37.61,500000,30,2010,500,"Санкт-Петербург");
            plane.Info();
            car.Info();
            ship.Info();
            Console.Read();
        }
    }
}
