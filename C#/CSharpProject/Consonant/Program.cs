using System;

namespace Consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz: ");
            string sentence = Console.ReadLine();

            string[] arr = sentence.Split(" ");

            string vowel = "aeıioöuü";

            foreach (string kelime in arr)
            {
                bool control = false;
                for (int i = 1; i < kelime.Length; i++)
                {
                    if (!vowel.Contains(kelime[i]) && !vowel.Contains(kelime[i - 1]))
                    {
                        control = true;
                    }
                }
                if (control == true)
                {
                    Console.Write("True ");
                }
                else
                {
                    Console.Write("False ");
                }
            }
        }
    }
}
