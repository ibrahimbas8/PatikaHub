using System;
using System.Collections.Generic;

namespace odev16CSharpGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //Sysytem.Collection.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(43);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Yesil");
            renkListesi.Add("red");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erisme
            foreach (int sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (string renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman cikarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("{0} liste icerisinde bulundu.", 10);

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi Liste cevirme
            string[] hayvanlar = { "kedi", "kopek", "kus" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanlarListesi.Clear();


            //Liste içerisinde nesne tutmak
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yilmaz";
            kullanici1.Yas = 26;
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ozcan";
            kullanici2.Soyisim = "Caliskan";
            kullanici2.Yas = 26;

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });


            foreach (Kullanicilar item in kullaniciListesi)
            {
                Console.WriteLine("Kullanici adi: " + item.Isim);
                Console.WriteLine("Kullanici soyadi: " + item.Soyisim);
                Console.WriteLine("Kullanici yas: " + item.Yas);
            }

            yeniListe.Clear();
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}
