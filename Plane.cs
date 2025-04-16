using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_2
{
    class Plane : Vehicle
    {
        public double height;
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 1000)
                {
                    value = 1000;
                }
                else
                {
                    height = value;
                }
            }
        }
        public Plane(double x, double y, double price, double speed, int year, int passengers, double height) : base(x, y, price, speed, year, passengers)
        {
            this.height = height;
        }

        public override void Info()
        {
            Console.WriteLine($"Самолёт:\nКоординаты:({X}, {Y})\nЦена: {Price} руб.\nСкорость: {Speed} км/ч\nГод выпуска: {Year} г.\nВысота: {Height} г.\nКоличество пассажиров: {Passengers} чел.\n");
        }
    }
}
