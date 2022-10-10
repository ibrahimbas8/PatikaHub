using System;

namespace odev4CSharpHataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayı Gir");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayi:" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            // finally
            //{
            //  Console.WriteLine("İşlem tamam");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-31313131313");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş değer girdin");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yanlış format");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("abartma");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("iş tamam");
            }
        }
    }
}
