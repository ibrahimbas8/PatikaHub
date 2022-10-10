using System;

namespace odev7CSharpFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı gir");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;

                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek toplam:" + tekToplam);
            Console.WriteLine("Çift toplam:" + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
            }
        }
    }
}
