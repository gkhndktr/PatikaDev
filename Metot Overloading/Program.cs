using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "9999";

            bool sonuc = int.TryParse(sayi, out int outsayi);

            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            //Metot aşırı yükleme - Overloading

            int ifade = 999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);

            instance.ekranaYazdir("Gökhan", "Döktür");

            //Metot imzası
            //metor adı + parametre sayısı + parametre

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void ekranaYazdir(string veri)
        {
        Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri)
        {
        Console.WriteLine(veri);
        }
        public void ekranaYazdir(string veri, string veri2)
        {
        Console.WriteLine(veri);
        }

    }
}
