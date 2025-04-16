using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110425
{
    class ClassRoom
    {
        public Pupil Pupil1;
        public Pupil Pupil2;
        public Pupil Pupil3;
        public Pupil Pupil4;
        public ClassRoom() { }
        public ClassRoom (Pupil Pupil1) { this.Pupil1 = Pupil1; }
        public ClassRoom (Pupil Pupil1, Pupil Pupil2) { this.Pupil1 = Pupil1; this.Pupil2 = Pupil2; }
        public ClassRoom (Pupil Pupil1, Pupil Pupil2,Pupil Pupil3) { this.Pupil1 = Pupil1; this.Pupil2 = Pupil2; this.Pupil3=Pupil3; }
        public ClassRoom (Pupil Pupil1, Pupil Pupil2,Pupil Pupil3, Pupil Pupil4) { this.Pupil1 = Pupil1; this.Pupil2 = Pupil2; this.Pupil3=Pupil3; this.Pupil4 = Pupil4; }

        public void InfoPup1()
        {
            Pupil1.Fio();
            Pupil1.Study();
            Pupil1.Read();
            Pupil1.Write();
            Pupil1.Relax();
        }
        public void InfoPup2()
        {
            Pupil2.Fio();
            Pupil2.Study();
            Pupil2.Read();
            Pupil2.Write();
            Pupil2.Relax();
        }
        public void InfoPup3()
        {
            Pupil3.Fio();
            Pupil3.Study();
            Pupil3.Read();
            Pupil3.Write();
            Pupil3.Relax();
        }
        public void InfoPup4()
        {
            Pupil4.Fio();
            Pupil4.Study();
            Pupil4.Read();
            Pupil4.Write();
            Pupil4.Relax();
        }
    }
}