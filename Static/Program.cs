using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("gökhan", "döktür", "it");
            Console.WriteLine("Çalışan sayısı {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("deniz", "döktür", "it");
            Calisan calisan3 = new Calisan("derya", "döktür", "it");
            Console.WriteLine("Çalışan sayısı {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işleminin sonucu {0}",İşlemler.Topla(10,10));
            Console.WriteLine("Çıkar işleminin sonucu {0}",İşlemler.Çıkar(10,10));


        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi {get=>calisanSayisi;}
        
        private string İsim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
                calisanSayisi ++;
        }
    }

    static class İşlemler
    {
        public static int Topla(int sayı1, int sayı2)
        {
            return  sayı1 + sayı2;
        }
        public static int Çıkar(int sayı1, int sayı2)
        {
            return  sayı1 - sayı2;
        }
    }
}
