using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425
{
    class BadPupil : Pupil
    {
        public BadPupil(string surname) : base(surname) { }
        public override void Fio()
        {
            Console.WriteLine($"Ученик {Surname}:");
        }
        public override void Study()
        {
            Console.WriteLine($"{Surname} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Surname} читает очень медленно!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Surname} пишет с большим количеством ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Surname} отдыхает, играая в компьютерные игры!");
        }
    }
}
