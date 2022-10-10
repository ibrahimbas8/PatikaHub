using System;

namespace odev12CSharpMetotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sayi = "999";
            int OutSayi;
            bool sonuc = int.TryParse(Sayi, out OutSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı.Veri Tipi Dönüştürülebilir!");
                Console.WriteLine("OutSayi =" + OutSayi);
            }
            else Console.WriteLine("Başarısız.Veri Dönüştürülebilecek Tipte Değil!");

            Methods instance = new Methods();
            instance.Topla(4, 5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);

            //Metot OverLoading/Aşırı Yükleme
            int ifade = 999;
            instance.EkranaYazdir(ifade);

            //Metot İmzası
            //Metot Adı+ Parametre Sayısı + Parametre.
            string Name = "Mehmet";
            string Surname = "BAYSOY";
            instance.EkranaYazdir(Name, Surname);
            //ya da
            instance.EkranaYazdir("Mehmet1", "BAYSOY");
        }
    }
    class Methods
    {
        public void Topla(int a, int b, out int Toplam)
        {
            Toplam = a + b;
        }
        public void EkranaYazdir(String Veri)
        {
            Console.WriteLine(Veri);
        }
        public void EkranaYazdir(int Veri)
        {
            Console.WriteLine(Veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + " " + veri2);
        }
    }
}
