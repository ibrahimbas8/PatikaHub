using System;
using System.Collections.Generic;
using System.Linq;

namespace odev9CSharpDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "it", "kedo", "birdman", "maymun" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            Console.WriteLine("Eleman sayısını gir:");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}. sayıyı gir:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }


            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama:" + toplam / diziUzunlugu);

        }
    }
}
