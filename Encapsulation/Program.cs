using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.İsim = "Gökhan";
            ogrenci.Soyisim = "Döktür";
            ogrenci.OgrenciNo = 709;
            ogrenci.Sınıf = 3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Döktür", 336, 1);
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

        }

    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string İsim {
            get {return isim;}
            set { isim = value;}
        }

        public string Soyisim{get=>soyisim; set =>soyisim = value;}

        public int OgrenciNo{
            get{
                return ogrenciNo;
            }
            set{
                ogrenciNo = value;
            }
        }
        public int Sınıf
         {
        get{return sinif;}
        set{
            if(value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
            }
            this.sinif = 1;
        }
        }

        public Ogrenci(){}
        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sınıf)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.OgrenciNo = ogrenciNo;
            this.Sınıf = sınıf;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****Öğrenci Bilgileri****");
            Console.WriteLine("Öğrenci Adı      :{0}",İsim.ToString());
            Console.WriteLine("Öğrenci Soyismi  :{0}",Soyisim.ToString());
            Console.WriteLine("Öğrenci Numarası :{0}",OgrenciNo.ToString());
            Console.WriteLine("Öğrenci Sınıfı   :{0}",Sınıf.ToString());

        }

        public void SinifAtlat()
        {
            this.Sınıf ++;
        }
        public void SinifDusur()
        {
            this.Sınıf --;
        }
    }
}
