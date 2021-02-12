using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    // Naming Convention
    // Syntax
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

            //
            //
        }

        // Doğru bir kullanım değil.
        public void Ekle2(string urunAdi,string aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
