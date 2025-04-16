using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_2
{
    class Ship : Vehicle
    {
        public string port;
        public string Port
        {
            get => port;
            set /*=> port = value;*/
            {
                if (value == "")
                {
                    port = "не указан";
                }
                else
                {
                    port = value;
                }
            }
        }
        public Ship(double x, double y, double price, double speed, int year, int passengers, string port) : base(x, y, price, speed, year, passengers)
        {
            this.Port = port;
        }

        public override void Info()
        {
            Console.WriteLine($"Самолёт:\nКоординаты:({X}, {Y})\nЦена:{Price} руб.\nСкорость: {Speed} км/ч\nГод выпуска: {Year} г.\nКоличество пассажиров: {Passengers} чел.\nПорт приписки: {Port}");
        }
    }
}
