using System;

namespace odev11CSharpMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);


            methods ornek = new methods(); // Class'ta yazdığımız metoda ulaşabilmek için tanımladık.
            ornek.EkranaYazdir(Convert.ToString(sonuc)); // sonuc int fakat metodumuz string ifade yazdırıyor. o yüzden Convert.ToInt'ı kullanıyoruz.

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));


            Console.ReadLine();
        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class methods
    {
        public void EkranaYazdir(string veri) // EkranaYazdir metoduna her yerden erişebilmek için public olarak tanımlıyoruz.
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
