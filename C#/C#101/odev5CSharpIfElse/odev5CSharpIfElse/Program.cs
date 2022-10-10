using System;

namespace odev5CSharpIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
            {
                System.Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                System.Console.WriteLine("İyi günler");
            }
            else
                System.Console.WriteLine("İyi geceler");

            string degisken = time <= 18 ? "İyi günler" : "İyi geceler";

            degisken = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi geceler";

            System.Console.WriteLine(degisken);
        }
    }
}
