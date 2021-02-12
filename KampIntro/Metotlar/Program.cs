using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 8;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type safe -- tip güvenli
            foreach (Urun temp in urunler)
            {
                Console.WriteLine(temp.Adi);
                Console.WriteLine(temp.Fiyati);
                Console.WriteLine(temp.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-------------Metodlar------------");

            // instance -- class örneği
            // Encapsulation
            SepetManager sm = new SepetManager();

            sm.Ekle(urunler[0]);
            sm.Ekle(urunler[1]);

            sm.Ekle2("Armut", "Yeşil armut", 12, 154);
            sm.Ekle2("Elma", "Yeşil elma", 12, 15);
            sm.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 9);
        }
    }
}



// Dont repeat yourself - DRY - Clean Code - Best Practise;