using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran Bilgilerini Değerlendirme
            //           
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager konutKrediManager, DateBaseLoggerService dateBaseLoggerService)
        {
            throw new NotImplementedException();
        }

        internal void BasvuruYap(IKrediManager konutKrediManager, loggerService fileLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
