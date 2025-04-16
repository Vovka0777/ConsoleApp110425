using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_2
{
    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year, int passengers) : base(x, y, price, speed, year, passengers)
        {}

        public override void Info()
        {
            Console.WriteLine($"Автомобиль:\nКоординаты:({X}, {Y})\nЦена: {Price} руб.\nСкорость: {Speed} км/ч\nГод выпуска: {Year} г.\nКоличество пассажиров: {Passengers} чел.\n");
        }
    }
}
