using System;

namespace CharacterReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cumle giriniz : ");
            string sentence = Console.ReadLine();
            string[] arr = sentence.Split();
            foreach (string item in arr)
            {
                char[] c = item.ToCharArray();
                char temp = c[c.Length - 1];
                c[c.Length - 1] = c[0];
                c[0] = temp;
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i]);
                }
                Console.Write(" ");
            }
        }
    }
}
