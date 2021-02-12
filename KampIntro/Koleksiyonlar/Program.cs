using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control + K  +  Control + C = comment
            // Control + K  +  Control + U = uncomment

            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// isimler[4] = "Ilker"; ArrayIndexOutOfBound

            //Console.WriteLine(isimler[4]);

            List<string> isimlerListesi = new List<string> { "Engin", "Murat", "Kerem" };
            isimlerListesi.Add("Halil");

            Console.WriteLine(isimlerListesi[0]);
            Console.WriteLine(isimlerListesi[1]);
            Console.WriteLine(isimlerListesi[2]);
            Console.WriteLine(isimlerListesi[3]);

            isimlerListesi.Add("Ilker");

            Console.WriteLine(isimlerListesi[4]);
            Console.WriteLine(isimlerListesi[0]);
        }
    }
}
