using System;

namespace odev17CSharpArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }
            // string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(liste.BinarySearch(9));

            liste.Reverse();

            Console.WriteLine();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            liste.Clear();
            Console.WriteLine();
            liste.Add(100);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
