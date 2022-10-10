using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class Log
    {
        static StreamWriter write;
        public Log()
        {
            string date = DateTime.Now.ToString("ddMMyyyy");
            string fileName = date + ".txt";
            write = new StreamWriter(@"C:\Users\basib\OneDrive\Masaüstü\kodlama\PATİKA\C#\CSharpProject\ATMApp\" + fileName);
        }
        public static void txtWrite(string data)
        {
            write.WriteLine(data);
        }
        public static void txtStop()
        {
            write.Close();
        }
        
    }
}
