using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_2
{
    abstract class Vehicle
    {
        private double x;
        private double y;
        private double price;
        private double speed;
        private int year;
        private int passengers;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Price { get => price; set
            {
                if (value < 0)
                {
                    value = 0;
                }

                else
                {
                    price = value;
                }
            }
        }
        public double Speed
        {
            get => speed; 
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
                    price = value;
                }
            }
        }
        public int Year { get => year;
        set
            {
                if (value < 1896)
                {
                    value = 1896;
                }

                else if (value > 2025)
                {
                    value = 2025;
                }

                else
                {
                    year = value;
                }
            }
        }

        public int Passengers { get => passengers; 
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                else if (value > 1000)
                {
                    passengers = 1000;
                }
                else
                {
                    passengers = value;
                }
            }
        }

        public Vehicle(double x, double y, double price, double speed, int year, int passengers)
        {
            this.X = x;
            this.Y = y;
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
            this.Passengers = passengers;
        }
        abstract public void Info();
    }
}
