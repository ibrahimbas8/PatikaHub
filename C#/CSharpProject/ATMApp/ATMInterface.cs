using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class ATMInterface
    {
        List<User> users = RegisteredUsers.users;
        User user;
        public ATMInterface()
        {
            Console.WriteLine();
            Console.WriteLine("ATM sistemine hoş geldiniz");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Giriş yapmak için müşteri no ve şifrenizi giriniz...");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            login();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("{0} sisteme başarıyla giriş yaptınız...", user.name);
            
            menu();
        }
        public void menu()
        {
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Yapabileceğin işlemler ");
                Console.WriteLine("1- Para çekme");
                Console.WriteLine("2- Para yatırma");
                Console.WriteLine("3- Bakiye sorma");
                Console.WriteLine("4- Ödeme Yapma");
                Console.WriteLine("5- Gün sonu");
                Console.WriteLine("6- Çıkış");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Seçmek istediğiniz işlemi giriniz: ");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Log.txtWrite("Para Çekme işlemi gerçekleştiriliyor...");
                    Account.withdrawMoney(user);
                }
                else if (choose == "2")
                {
                    Log.txtWrite("Para Yatırma işlemi gerçekleştiriliyor...");
                    Account.deposit(user);
                }
                else if (choose == "3")
                {
                    Log.txtWrite("Bakiye gösterme işlemi gerçekleştiriliyor...");
                    Account.balancePrint(user);
                }
                else if (choose == "4")
                {
                    Log.txtWrite("Ödeme menüsü görüntüleniyor...");
                    Console.WriteLine("Menü hizmet dışıdır iyi günler");
                }
                else if (choose == "5")
                {
                    Log.txtWrite("Gün sonu menüsü görüntüleniyor...");
                    Console.WriteLine("Menü hizmet dışıdır iyi günler");
                }
                else if (choose == "6")
                {
                    Log.txtWrite(user.customerNo + " nolu müşteri çıkış yaptı...");
                    Console.WriteLine("Çıkış yapılıyor iyi günler {0}", user.name);
                    Log.txtStop();
                    stop = false;
                }
                else
                {
                    Log.txtWrite("menüde hatalı giriş gerçekleşti...");
                    Console.WriteLine("Hatalı giriş");
                }
            }
        }
        public void login()
        {
            bool stop = true, flag;
            int customerNo;
            string pass;
            while (stop)
            {
                Console.Write("Müşteri no giriniz: ");
                customerNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Şifre giriniz: ");
                pass = Console.ReadLine();
                flag = checkUserInfo(customerNo, pass);
                if (flag == true)
                {
                    Console.WriteLine("Sisteme giriş yapılıyor");
                    stop = false;
                }
            }
        }
        bool checkUserInfo(int customerNo, string pass)
        {
            bool flag = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].customerNo == customerNo && users[i].password == pass)
                {
                    flag = true;
                    Console.WriteLine("Kullanıcı adı ve şifre doğru");
                    user = users[i];
                    Log.txtWrite(user.customerNo + " nolu müşteri sisteme başarılı bir şekilde girdi...");
                    break;
                }
            }
            if (flag == false)
            {
                Log.txtWrite("Kullanıcı adı veya şifre hatalı giriş");
                Console.WriteLine("Kullanıcı adı veya şifre hatalı tekrar deneyiniz...");
            }
            return flag;
        }
    }
}
