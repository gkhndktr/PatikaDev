using System;

namespace Sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            //class SınıfAdı
            //{
            //  [erişim belirleyici] [veri tipi ] özellik adı;
            //  [erişim belirletici] [geri dönüş tipi] MetotAdi([Parametre listesi])
            //  {
            //  //Metot komutları
            //  }
            //}


            // Erişim belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protocol

            Calisan calisan1 = new Calisan();

            calisan1.Adı = "Gökhan";
            calisan1.Soyadı = "Döktür";
            calisan1.No = 55555;
            calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");
            Calisan calisan2 = new Calisan();
            calisan2.Adı ="Deniz";
            calisan2.Soyadı = "Döktür";
            calisan2.No = 44444;
            calisan2.Departman ="IT";
            
            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string Adı;
            public string Soyadı;
            public int No;

            public string Departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın adı:{0}", Adı);
                Console.WriteLine("Çalışanın soyadı:{0}", Soyadı );
                Console.WriteLine("Çalışanın numarası:{0}", No);
                Console.WriteLine("Çalışanın departmanı:{0}", Departman);
            }
        }
    }
}
