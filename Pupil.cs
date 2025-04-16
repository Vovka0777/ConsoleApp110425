using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425
{
    abstract class Pupil
    {
        string surname;
        public string Surname { get => surname; set => surname = value; }
        public Pupil(string surname) { this.Surname = surname; }
        public abstract void Fio();
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
