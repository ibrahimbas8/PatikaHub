using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class Account
    {
        public Account() { }
        public static void withdrawMoney(User user)
        {
            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para çekme işlemi gerçekleştiriliyor");
            if (user.balance >= quantity)
            {
                user.balance -= quantity;
                Console.WriteLine("Başarılı");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Kalan tutar {0}", user.balance);
                Console.WriteLine("------------------------------------------------------");
                Log.txtWrite(quantity + " Tl çekildi yeni bakiye " + user.balance + " tl dir...");
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye");
                Console.WriteLine("------------------------------------------------------");
                Log.txtWrite(user.customerNo + " no lu müşteri hesap bakiyesi yetersiz");
            }
        }
        public static void deposit(User user)
        {
            Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para yatırma işlemi gerçekleştiriliyor");
            user.balance += quantity;

            Console.WriteLine("Başarılı");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Yeni bakiye {0}", user.balance);
            Console.WriteLine("------------------------------------------------------");
            Log.txtWrite(user.customerNo + " nolu müşteri " + quantity + " Tl yatırdı yeni bakiye " + user.balance + " tl dir...");
        }
        public static void balancePrint(User user)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Bakiyeniz {0} TL dir...", user.balance);
            Console.WriteLine("------------------------------------------------------");
            Log.txtWrite(user.customerNo + " nolu müşteri hesap bakiyesi " +  user.balance + " tl dir...");
        }
    }
}
