using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta05_03_OOP1
{
    class Kedi:Hayvan
    {
        public override void Tanit()
        {
            Console.WriteLine("Ben kediyim");
            base.Tanit();
        }
    }
}
