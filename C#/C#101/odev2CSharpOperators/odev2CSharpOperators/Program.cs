using System;

namespace odev2CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 4, sayi2 = 15, sayi3 = sayi1 + sayi2;
            Console.WriteLine(sayi3);
            sayi1 = sayi3 - sayi2;
            Console.WriteLine(sayi1);

            int sonuc = sayi1++;
            //Önce sayi1 değişkenini 1 arttır, daha sonra onun değerini ifade içinde
            //kullan
            int sonuc2 = ++sayi1;
            //Önce sayi1 değişkeninin değerini ifade içinde kullan, daha sonra onun
            //değerini 1 arttır.
            Console.WriteLine(sonuc);   //
            Console.WriteLine(sonuc2);  //
            int sonuc3 = sayi1--;
            int sonuc4 = --sayi1;
            Console.WriteLine(sonuc3);  //
            Console.WriteLine(sonuc4);  //

            int y = y + 23;
            Console.WriteLine(y);
            y += -5;
            Console.WriteLine(y);
            y /= 10;
            Console.WriteLine(y);
            int x = 2;
            x *= 2;
            Console.WriteLine(x);
            byte SayiA = 65, SayiB = 67;
            bool SayiA_Buyuktur_SayiB = SayiA > SayiB;
            bool SayiB_Buyuktur_SayiA = SayiB > SayiA;
            bool SayiA_EsitMi_SayiB = SayiB == SayiA;
            bool SayiA_SayiB_yeEsitDegildir = SayiA != SayiB;
            // bool SayiA_SayiB_yeEsitDegildir=!SayiA_EsitMi_SayiB;

            if (SayiA_Buyuktur_SayiB)
            {
                Console.WriteLine("SayiA({0}) SayiB({1})'den Büyüktür.", SayiA, SayiB);
            }
            if (SayiB_Buyuktur_SayiA)
            {
                Console.WriteLine("SayiB({0}) SayiA({1})'dan Büyüktür.", SayiB, SayiA);
            }
            if (SayiA_EsitMi_SayiB)
            {
                Console.WriteLine("SayiA({0}) = SayiB({1})", SayiA, SayiB);
            }
            // küçük  eşittir ,büyük eşittir mantığı yapalım.
            // <= >= mantığıdır.
            if (SayiA_EsitMi_SayiB || SayiA_Buyuktur_SayiB)
            {
                Console.WriteLine("SayiA({0}) = SayiB({1}) veya SayiA({0}) > SayiB({1})",
                                  SayiA, SayiB);
            }
            if (SayiA_EsitMi_SayiB || SayiB_Buyuktur_SayiA)
            {
                Console.WriteLine("SayiA({0}) = SayiB({1}) veya SayiB({1}) > SayiA({0})",
                                  SayiA, SayiB);
            }
            //! bool kullanımı
            // SayiA_EsitMi_SayiB false olursa
            //! SayiA_EsitMi_SayiB true olur.yani tam tersi
            if (!SayiA_EsitMi_SayiB)
            {
                Console.WriteLine("SayiA({0}) != SayiB({1})", SayiA, SayiB);
            }
            // a mod b
            byte a = 45, b = 10;
            Console.WriteLine(a % b);
        }
    }
}
