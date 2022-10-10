using System;

using BarcodeLib;
using System.Text.Json;

namespace BarcodeGenerator
{
    class BarcodeOperation
    {
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(@"C:\Users\basib\OneDrive\Masaüstü\kodlama\PATİKA\C#\CSharpProject\BarcodeGenerator\BarcodePng\"  + data +".png",  BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu ve kaydedildi, saklanan data -> {0}", data);
            return barcode;
        }
        public static string ReadBarcode(Barcode barcode)
        {
            return "Barkod değeri = " + barcode.RawData ;
        }
    }
}
