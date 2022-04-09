using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta05_03_OOP1
{
    public class Turk:Insan
    {
        public override void Tanit()
        {
            Console.WriteLine($"ben türk insanıyım adım {Isim} {Soyad}");
        }

        public override void SetSoyad(string sa)
        {
            base.SetSoyad(sa);
        }
    }
}
