using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini Tekrarlama
            //değer tutucu(kategoriEtiketi) yani alias:takma isimdir.

            string kategoriEtiketi = "Kategoriler ";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }
 
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }     
             
            Console.WriteLine(kategoriEtiketi);





        }
    }
}
