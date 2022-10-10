using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
        a1:
            try
            {
                System.Console.WriteLine("Lütfen bir kelime giriniz;");
                string y = Console.ReadLine();
                System.Console.WriteLine("Lütfen yok etmek istediğiniz harflerin basamaklarını tekrar tekrar giriniz:");
                ShowTime(y); goto a1;

                static void ShowTime(string y)
                {
                    int start = 1;
                    int miktar = y.Length;
                    while (start <= miktar)
                    {
                        Int32 x = Int32.Parse(Console.ReadLine());
                        y = y.Remove(x, 1);
                        System.Console.WriteLine("Cevap: {0}", y);
                        start++;
                    }
                }
            }

            catch { System.Console.WriteLine("Hata aldınız... Ana menüye gidiyorsunuz."); goto a1; }
        }
    }
}
