using System;

namespace intTwoNumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N sayısı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n*2];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("N sayılarını teker teker giriniz:"); //sayı dışı giriş hata
                arr[i] = Convert.ToInt32(Console.ReadLine());      
            }
            for (int i = 0; i < arr.Length; i+=2)
            {
                if (arr[i] == arr[i+1])
                {
                    int temp = (arr[i] + arr[i + 1]) * (arr[i] + arr[i + 1]);
                    Console.Write(temp + " ");
                }
                else
                {
                    Console.Write(arr[i] + arr[i + 1] + " ");
                }
            }
        }
    }
}
