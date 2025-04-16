using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_4
{
    internal class Ukraine : Person
    {
        public Ukraine(string name) { Name = name; }
        public override void SayHello()
        {
            Console.WriteLine($"Привiт, {Name}!");
        }
    }
}
