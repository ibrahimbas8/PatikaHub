using System;
using System.Linq;

namespace Project2ToDo
{
    internal class DeletingCard : IOperations
    {
        public void Delete()
        {
        againDo:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string input = Console.ReadLine();

            Card card = Database.Cards.FirstOrDefault(x => x.Title == input);
            if (card != null)
            {
                Database.Cards.Remove(card);
            }
            else
            {
            againTry:
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n * Silmeyi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }
                else if (choice == 2)
                {
                    goto againDo;
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                    goto againTry;
                }
            }
        }
    }
}
