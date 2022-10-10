using System;

namespace odev22CSharpEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = -2;
            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("havanın ısınmasını  bekle");
            }
            else if (sıcaklık >= (int)HavaDurumu.Sicak)
            {
                System.Console.WriteLine("Çok Sıcak Çıkma Yanarsın");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSicak)
            {
                System.Console.WriteLine("Dışarı Çık!!");
            }
        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 4,
        Normal = 20,
        Sicak = 30,
        CokSicak = 35,
    }
}
