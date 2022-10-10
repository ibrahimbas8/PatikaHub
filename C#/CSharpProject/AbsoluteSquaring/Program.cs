using System;

namespace AbsoluteSquaring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N sayısı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("sayı giriniz : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallSum = 0, bigSumSquare = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 67)
                {
                    smallSum += (67 - arr[i]);
                }
                else
                {
                    bigSumSquare += (arr[i] - 67) * (arr[i] - 67);
                }
            }
            Console.WriteLine(smallSum + " " + bigSumSquare);
        }
    }
}
