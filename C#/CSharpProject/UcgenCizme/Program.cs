using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çizilecek üçgen için taban değerini giriniz:");

            int length = Convert.ToInt32(Console.ReadLine());

            triangle(length);
        }
        public static void triangle(int length)
        {
            for (int i = length; i > 0; i--)
            {
                for (int j = 0; j <= length - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
