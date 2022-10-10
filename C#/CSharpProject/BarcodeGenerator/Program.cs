using System;
using System.Collections.Generic;
using System.Diagnostics;
using BarcodeLib;
using Honeywell.AIDC.CrossPlatform;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose, data;
            List<Barcode> barcodeList = new List<Barcode>();
            Barcode barcode;
            bool stop = true;
            while (stop)
            {
                Console.Write("Barkod oluşturmak için 1, barkod okumak için 2, çıkış için 3 e basınız...");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine("Barkod datası giriniz...");
                    data = Console.ReadLine();
                    //barcode = BarcodeOperation.CreateAndSaveBarcode(data);
                    barcodeList.Add(BarcodeOperation.CreateAndSaveBarcode(data));
                }
                else if (choose == "2")
                {
                    Console.WriteLine("Aradığınız barkodun datasını giriniz...");
                    data = Console.ReadLine();
                    bool isThere = false;
                    foreach (Barcode item in barcodeList)
                    {
                        if (item.RawData == data)
                        {
                            Console.WriteLine(BarcodeOperation.ReadBarcode(item) + " nolu barkod datası bulunmaktadır.");
                            isThere = true;
                        }
                        
                    }
                    if (isThere==false)
                    {
                        Console.WriteLine("Maalesef barkod bulunmamaktadır.");
                    }
                }
                else if (choose == "3")
                {
                    stop = false;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş...");
                }
            }
        }
    }
}
