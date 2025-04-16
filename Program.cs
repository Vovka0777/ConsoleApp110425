using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.Pupil1 = new ExcelentPupil("Петров");
            classRoom.Pupil2 = new GoodPupil("Иванов");
            classRoom.Pupil3 = new BadPupil("Сидоров");
            classRoom.Pupil4 = new ExcelentPupil("Ткачук");

            classRoom.InfoPup1();
            Console.WriteLine();

            classRoom.InfoPup2();
            Console.WriteLine();

            classRoom.InfoPup3();
            Console.WriteLine();
                
            classRoom.InfoPup4();
            Console.Read();
        }
    }
}
