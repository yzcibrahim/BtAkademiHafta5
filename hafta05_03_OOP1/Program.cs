using System;

namespace hafta05_03_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Canli insan1 = new Insan();
            // insan1.Isim = "ibrahim";
            //// insan1.Soyad = "yazıcı";
            // insan1.Yasa();
            // insan1.Tanit();

            // Canli hayvan = new Hayvan();
            // hayvan.Isim = "Tom";
            // hayvan.Yasa();
            // hayvan.Tanit();

            //Canli c = new Kedi();
            //c.Tanit();
            Insan c = new Insan();
            //((Insan)c).
            c.Isim = "test";
            //  c.Soyad = "deneme";
            c.SetSoyad("deneme");


            Turk t = new Turk();
            t.Isim = "asdasd";
            t.SetSoyad("soyad");
         //   t.Soyad="asdasd"

            return;


        }
    }
}
