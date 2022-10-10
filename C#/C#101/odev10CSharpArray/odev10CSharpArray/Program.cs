using System;

namespace odev10CSharpArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++ Sırasız Dizi ++++++++++++++");

            int[] sayiDizisi = { 23, 31, 5, 69, 72, 41, 99, 3 };
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("+++++++ Sıralı Dizi ++++++++++++++");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);



            Console.WriteLine("+++++++ Array clear ++++++++++++++");
            Array.Clear(sayiDizisi, 3, 3);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("+++++++ Reverse ++++++++++++++");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine("+++++++ Indexof ++++++++++++++");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            Console.WriteLine("+++++++ Resize ++++++++++++++");

            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 77;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
