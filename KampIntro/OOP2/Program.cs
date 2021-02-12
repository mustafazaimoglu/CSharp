using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNumarasi = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNumarasi = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNumarasi = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNumarasi = "12345678910";

            // Gerçek - Tüzel
            // SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
