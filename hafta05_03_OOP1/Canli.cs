using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta05_03_OOP1
{
    public class Canli
    {
        public string Isim { get; set; }
        
        public void Yasa() 
        {
            Console.WriteLine("Yaşıyorum");
        }

        public virtual void Tanit()
        {
            Console.WriteLine($"Ben Canlıyım benim Adım:{Isim}");
        }
    }
}
