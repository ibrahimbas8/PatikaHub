using System;

namespace odev19CSharpConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Çalışan 1************");
            Calisan calisan1 = new Calisan("Emre", "Öztürk", 403, "QA");

            calisan1.calisanBilgiler();

            Console.WriteLine("************Çalışan 2************");
            Calisan calisan2 = new Calisan();
            calisan2.ad = "Ahmet";
            calisan2.soyad = "Öztürk";
            calisan2.no = 563;
            calisan2.departman = "Dev";

            calisan2.calisanBilgiler();
            Console.WriteLine("************Çalışan ***********");

            Calisan calisan3 = new Calisan("Dilara", "Öztürk");
            calisan3.calisanBilgiler();
        }
    }
    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void calisanBilgiler()
        {
            Console.WriteLine("Çalışan adı:{0}", ad);
            Console.WriteLine("Çalışan soyad:{0}", soyad);
            Console.WriteLine("Çalışan no:{0}", departman);
            Console.WriteLine("Çalışan departman:{0}", departman);

        }

        public Calisan() { }

        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }


        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }
    }
}
