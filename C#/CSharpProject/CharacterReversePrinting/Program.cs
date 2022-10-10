using System;

namespace CharacterReversePrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Cumle giriniz : ");
            string sentence = Console.ReadLine();
            string[] arr = sentence.Split(" ");
            foreach (string item in arr)
            {
                char[] c = item.ToCharArray();
                for (int i = 1; i < c.Length; i++)
                {
                    Console.Write(c[i] + "");
                }
                Console.Write(c[0] + " ");
            }
        }
    }
}
