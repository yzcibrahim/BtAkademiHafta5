using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta05_03_OOP1
{
    public class Insan:Canli
    {
        protected string Soyad { get; set; }

        public override void Tanit()
        {
            Console.WriteLine($"ben insanım benim adım {Isim} {Soyad}");
        }
        public virtual void SetSoyad(string sa)
        {
            Soyad = sa;
        }

    }
}
