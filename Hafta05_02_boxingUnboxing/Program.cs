using System;
using System.Collections.Generic;

namespace Hafta05_02_boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            object obj = a;


            int unboxedVal = (int)obj;

            List<object> karisikListe = new List<object>();

            karisikListe.Add(5);
            karisikListe.Add("asd");
            karisikListe.Add(8);
            int toplam = 0;
            foreach (var item in karisikListe)
            {
                if(item is int)
                toplam += (int)item;
            }
        }
    }
}
