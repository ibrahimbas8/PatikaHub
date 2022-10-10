using System;

namespace odevCSharpAlgoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            /*Console.Write("N sayısı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sayi,sayac=0;
            while (sayac < n)
            {
                Console.Write("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    sayac++;
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
                else Console.WriteLine("pozitif sayı giriniz");
            }*/

            //2Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            /*Console.Write("N sayısını giriniz:");
            int n = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("M sayısını giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());
            int sayi, sayac = 0;
            while (sayac < n)
            {
                Console.Write("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    sayac++;
                    if(sayi==m || sayi % m == 0) Console.WriteLine(sayi) ;
                }
                else Console.WriteLine("pozitif sayı giriniz");
            }*/

            //3Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            /*Console.WriteLine("lütfen bir sayı giriniz");
            int sn = int.Parse(Console.ReadLine());
            string[] dizi3 = new string[sn];

            for (int i = 0; i < sn; i++)
            {
                Console.WriteLine("lütfen {0}. kelimeyi giriniz", i + 1);
                dizi3[i] = Console.ReadLine();
            }

            for (int i = sn - 1; i >= 0; i--)
            {
                Console.WriteLine(dizi3[i]);
            }

            // 4.soru girilen cümlenin kelime ve harf sayısını bulan kod

            Console.Write("Bir cümle giriniz:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            int letters = 0;
            Console.WriteLine("Cümlede {0} kelime var" , words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                letters += words[i].Length;
            }
            Console.WriteLine("Cümlede {0} harf var" , letters);*/

        }
    }
}
