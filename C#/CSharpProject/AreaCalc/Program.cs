using System;

namespace AreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge1, edge2, r;
            int chooseShape, temp;
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("Şekil seçiniz");
                Console.Write("Daire için 1 - Üçgen için 2 - Kare için 3 - Dikdörtgen için 4 - Çıkış için 5:");
                chooseShape = Convert.ToInt32(Console.ReadLine());
                if (chooseShape == 1)
                {
                    Console.Write("Yarı çap değerini giriniz:");
                    r = Convert.ToDouble(Console.ReadLine());

                    temp = chooseType();
                    if (temp == 1)
                    {
                        double circlePerimeter = 2 * 3.14 * r;
                        Console.WriteLine("Dairenin çevresi : {0}", circlePerimeter);
                    }else if(temp == 2)
                    {
                        double circleSquare = 3.14 * r *r;
                        Console.WriteLine("Dairenin çevresi : {0}", circleSquare);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş");
                    }
                }
                else if (chooseShape == 2)
                {
                    temp = chooseType();
                    if (temp == 1)
                    {
                        Console.Write("Bir kenar değerini giriniz:");
                        edge1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Bir kenar değerini giriniz:");
                        edge2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Bir kenar değerini giriniz:");
                        double edge3 = Convert.ToDouble(Console.ReadLine());
                        double triangelPerimeter = edge1 + edge2 + edge3;
                        Console.WriteLine("Üçgenin çevresi : {0}", triangelPerimeter);
                    }
                    else if (temp == 2)
                    {
                        Console.Write("Taban kenar değerini giriniz:");
                        edge1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Yükseklik değerini giriniz:");
                        edge2 = Convert.ToDouble(Console.ReadLine());
                        double triangleSquare = edge1 * edge2 / 2;
                        Console.WriteLine("Üçgenin alanı : {0}", triangleSquare);
                    }
                }
                else if (chooseShape == 3)
                {
                    Console.Write("Bir kenar değerini giriniz:");
                    edge1 = Convert.ToDouble(Console.ReadLine());

                    fourCorners(edge1, edge1);
                }
                else if (chooseShape == 4)
                {
                    Console.Write("Uzun kenar değerini giriniz:");
                    edge1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kısa kenar değerini giriniz:");
                    edge2 = Convert.ToDouble(Console.ReadLine());

                    fourCorners(edge1, edge2);
                }
                else if (chooseShape == 5)
                {
                    stop = false;
                }
                else Console.WriteLine("hatalı seçim tekrar dene...");
            }
           
        }
        public static int chooseType()
        {
            Console.WriteLine("Çevre hesabı için 1- Alan hesabı için 2 yi seçiniz");
            int choose = Convert.ToInt32(Console.ReadLine());

            return choose;
        }
        public static void fourCorners(double x, double y)
        {
            int temp = chooseType();
            if (temp == 1)
            {
                perimeterFourCorners(x,y);
            }
            else if (temp == 2)
            {
                squareFourCorners(x, y);
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
        }
        public static void perimeterFourCorners(double x, double y)
        {
            double perimeter = x * 2 + y * 2;
            Console.WriteLine("Seçtiğiniz şeklin çevresi: {0}", perimeter);
        }
        public static void squareFourCorners(double x, double y)
        {
            double square = x * y;
            Console.WriteLine("Seçtiğiniz şeklin çevresi: {0}", square);
        }
    }
}
