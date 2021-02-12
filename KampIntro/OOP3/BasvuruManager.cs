using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuru bilgilerini değerlendirme
            // 
            //

            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(IKrediManager ikm in krediler)
            {
                ikm.Hesapla();
            }
        }
    }
}
