using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "Programlamaya Başlangıç İçin Temel Kurs" ,
                "Java" , "Pyhton"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
