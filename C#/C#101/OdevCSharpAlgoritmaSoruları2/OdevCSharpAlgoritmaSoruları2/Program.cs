using System;
using System.Collections;

namespace OdevCSharpAlgoritmaSoruları2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int sayac = 0, sayi;
            while (sayac < 20)
            {
                try
                {
                    Console.Write("Sayı giriniz: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                    {
                        list.Add(sayi);
                        sayac++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz...");
                }
            }

            //1 Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            //(ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            soruBir(list);

            //2Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun
            //kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a
            //yazdıran programı yazınız.(Array sınıfını kullanarak yazınız.)

            soruIki(list);

            //3Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve
            //dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir cümle giriniz: ");
            string[] sentence = Console.ReadLine().Split(' ');
            string[] character = { "a", "e", "ı", "i", "o", "ö", "ü", "u" };

            ArrayList vowels = new ArrayList();

            for (int i = 0; i < sentence.Length; i++)
            {
                foreach (var item in character)
                {
                    if (sentence[i].Contains(item))
                    {
                        vowels.Add(item);
                    }
                }
            }

            Console.WriteLine("Yazılan cümlede kullanılan sesli harfler: ");

            foreach (var item in vowels)
            {
                Console.WriteLine(item);
            }
        }
        public static void soruBir(ArrayList list)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            
            foreach (int sayi in list)
            {
                bool asalMi = true;
                for (int i = 2; i < sayi ; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        asalDegil.Add(sayi);
                        break;
                    }
                    
                }
                if (asalMi == true) asal.Add(sayi);
            }

            asal.Sort();
            asalDegil.Sort();
            int temp = 0;
            Console.WriteLine("Asal");
            foreach (int sayi in asal)
            {
                Console.WriteLine(sayi);
                temp += sayi;
            }
            Console.WriteLine("Adet : " + asal.Count);
            Console.WriteLine("ortalama : " + temp/asal.Count);
            Console.WriteLine("Asal değil");
            temp = 0;
            foreach (int sayi in asalDegil)
            {
                temp += sayi;
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Adet : " + asalDegil.Count);
            Console.WriteLine("ortalama : " + temp / asalDegil.Count);
        }
        public static void soruIki(ArrayList list)
        {
            Console.WriteLine("----------------------------");
            list.Sort();
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
                temp  += (int)list[i];
            }
            Console.WriteLine("İlk 3 ortalama: " + temp/3);
            int temp2 = 0;
            for (int i = list.Count - 3; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                temp2 += (int)list[i];
            }
            Console.WriteLine("Son 3 ortalama: " + temp2/3);
            Console.WriteLine("Ort toplam: " + temp/3+temp2/3);
        }
    }
}
