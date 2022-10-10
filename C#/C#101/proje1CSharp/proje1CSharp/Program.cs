using System;

namespace proje1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneList.PhoneNumberList.Add(new Person("Ece", "Selim", "342"));
            PhoneList.PhoneNumberList.Add(new Person("Aslı", "Akay", "2364"));
            PhoneList.PhoneNumberList.Add(new Person("Mehmet", "Gür", "457"));
            PhoneList.PhoneNumberList.Add(new Person("Ali", "Kılıç", "346"));
            PhoneList.PhoneNumberList.Add(new Person("Eda", "Aşçı", "685"));

            Operation.StartPrint();
            int select = int.Parse(Console.ReadLine());
            while (Operation.ControlNumber(select))
            {
                if (select == 1)
                {
                    Operation.saveNumber();
                }
                else if (select == 2)
                {
                    Operation.deleteNumber();
                }
                else if (select == 3)
                {
                    Operation.UpdateNumber();
                }
                else if (select == 4)
                {
                    Operation.printNumberList();
                }
                else if (select == 5)
                {
                    Operation.SearchNumber();
                }
                else
                {
                    Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                    break;
                }
                Operation.StartPrint();
                select = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Rehberin Son Hali: ");
            Operation.printNumberList();
            Console.WriteLine("Program Sona Erdi, Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();
        }
    }
}
