using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 85;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mustafa";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 78;

            // Console.WriteLine(kurs1.IzlenmeOrani + " " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " --> " + kurs.Egitmen + " --> " + kurs.IzlenmeOrani);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        // Properties
        public string KursAdi;
        public string Egitmen;
        public int IzlenmeOrani;


    }
}
