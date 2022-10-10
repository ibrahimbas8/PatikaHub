using System;

namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz:");
            int num = Convert.ToInt32(Console.ReadLine());
            print(num);
        }
        static double  fib(int deep)
        {
            int x = 0, y = 0, z = 1;
            double sum = 1;
            for (int i = 0; i < deep-1; i++)
            {
                x = y;
                y = z;
                z = x + y;
                sum += z;
            }
            return sum;
        }
        static double average(int deep)
        {
            double sum = fib(deep);
            double avaregeFib = sum / deep;
            return avaregeFib;
        }
        static void print(int deep)
        {
            Console.WriteLine("average Fib: " + average(deep));
        }
    }
}
