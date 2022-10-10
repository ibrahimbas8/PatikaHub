using System;
using System.Collections.Generic;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("narkoz", "123456");
            User user2 = new User("karizma", "123456");
            User user3 = new User("emsalsiz", "123456");
            User user4 = new User("deli", "123456");
            List<User> users = new List<User> { user, user2, user3, user4 };

            Categories filmKategorisi;
            Categories c1 = new Categories(FilmCategories.Korku, 5);
            Categories c2 = new Categories(FilmCategories.Dram, 10);
            Categories c3 = new Categories(FilmCategories.Komedi, 7);
            Categories c4 = new Categories(FilmCategories.Fantastik, 8);
            List<Categories> categories = new List<Categories>() { c1, c2, c3, c4 };
            bool finishIt = true;
            while(finishIt)
            {
                try
                {
                    login();
                    chooseCategory();
                    votingRatePrint();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Çıkmak için 1 e devam etmek için enter a basınız...");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    finishIt = false;
                }
            }
            void login()
            {
                bool control = true;
                bool flag = false;
                while (control)
                {
                    Console.WriteLine("Giriş için 1 e basınız - Kayıt için 2 ye basınız...");
                    string s = Console.ReadLine();
                    if (s == "1")
                    {
                        Console.Write("Lütfen kullanıcı adını giriniz: ");
                        string username = Console.ReadLine();
                        Console.Write("Lütfen şifrenizi giriniz: ");
                        string pass = Console.ReadLine();
                        flag = checkUserInfo(username, pass);
                        if (flag == true) control = false;
                    }
                    else if (s == "2")
                    {
                        register();
                        control = false;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş");
                    }
                }
            }
            bool checkUserInfo(string username, string pass)
            {
                bool flag = false;
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Username == username && users[i].Pass == pass)
                    {
                        flag = true;
                        Console.WriteLine("Kullanıcı adı ve şifre doğru");
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı...");
                }
                return flag;
            }

            void register()
            {
                Console.Write("Lütfen kullanıcı adınızı giriniz: ");
                string username = Console.ReadLine();
                Console.Write("Lutfen şifrenizi giriniz: ");
                string pass = Console.ReadLine();
                User newUser = new User(username, pass);
                users.Add(newUser);
                Console.WriteLine("Kaydınız başarıyla oluşturuldu.");
                Console.WriteLine("-------------------------------------------");
            }

            void votingRatePrint()
            {
                Dictionary<string, int> voteRate = new Dictionary<string, int>();

                voteRate["Korku"] = 0;
                voteRate["Dram"] = 0;
                voteRate["Komedi"] = 0;
                voteRate["Fantastik"] = 0;
                int totalVote = 0;

                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].FilmKategorisi == FilmCategories.Korku)
                        voteRate["Korku"] += categories[i].currentVoteRate;
                    else if (categories[i].FilmKategorisi == FilmCategories.Dram)
                        voteRate["Dram"] += categories[i].currentVoteRate;
                    else if (categories[i].FilmKategorisi == FilmCategories.Komedi)
                        voteRate["Komedi"] += categories[i].currentVoteRate;
                    else //Romantik_Komedi
                        voteRate["Fantastik"] += categories[i].currentVoteRate;
                    totalVote += categories[i].currentVoteRate;
                }
                Console.WriteLine("-----------------------------------------------------");
                double percent = 0;
                string end = "";
                foreach (var item in voteRate)
                {
                    Console.WriteLine("{0} filmleri kategorisi için oy miktarı: {1}", item.Key, item.Value);
                    percent = (double)item.Value / (double)totalVote * 100;
                    end = String.Format("{0:0.00}", percent); //virgulden (decimal point) sonra yalnizca iki basamak alacak.
                    Console.WriteLine("{0} filmleri kategorisi için yüzdelik oy miktarı: {1}", item.Key, end);
                }
            }

            void chooseCategory()
            {
                Console.WriteLine("Hoş geldiniz, oy vermek istediğiniz film kategorisini seçiniz.");
                Console.WriteLine("(1)Korku");
                Console.WriteLine("(2)Dram");
                Console.WriteLine("(3)Komedi");
                Console.WriteLine("(4)Fantastik");
                int choose = int.Parse(Console.ReadLine());
                int value=0;
                bool stop = true;
                while (stop)
                {
                    Console.Write("1 ile 10 arası oy değerini giriniz: ");
                    value = int.Parse(Console.ReadLine());
                    if (value > 1 && value < 11)
                    {
                        Console.WriteLine("Oy sisteme ekleniyor"); 
                        stop = false;
                    }
                    else Console.WriteLine("Hatalı giriş tekrar giriniz...");
                }
                
                switch (choose)
                {
                    case 1:
                        filmKategorisi = new Categories(FilmCategories.Korku, value);
                        UpdateCategory(filmKategorisi);
                        break;
                    case 2:
                        filmKategorisi = new Categories(FilmCategories.Dram, value);
                        UpdateCategory(filmKategorisi);
                        break;
                    case 3:
                        filmKategorisi = new Categories(FilmCategories.Komedi, value);
                        UpdateCategory(filmKategorisi);
                        break;
                    case 4:
                        filmKategorisi = new Categories(FilmCategories.Fantastik, value);
                        UpdateCategory(filmKategorisi);
                        break;
                    default:
                        break;
                }
            }
            void UpdateCategory(Categories category)
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].FilmKategorisi == category.FilmKategorisi)
                        categories[i].currentVoteRate += category.currentVoteRate; //mevcut olan degere eklenerek guncellenecek
                }
            }
        }
    }
}
