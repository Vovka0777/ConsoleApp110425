using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425_4
{
    abstract class Person
    {
        public string Name { get; set; }
        public abstract void SayHello();
    }
}
