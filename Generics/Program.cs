using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<T> class 
            //System.Collections.Generic

            //T ->object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(12);
            sayiListesi.Add(10);
            sayiListesi.Add(5);
            sayiListesi.Add(4);
            sayiListesi.Add(92);
            sayiListesi.Add(34);
            sayiListesi.Add(2);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //foreach ve List.foreach ile elemanlara erişim.
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            sayiListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            sayiListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }


            //Elaman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));//???

            //Diziyi listeye çevirme
            string[] hayvanlar = {"Kedi", "Köpek","Kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanlarListesi.Clear();
            
            //Liste içerisinde nesne tutmak
            List<Kullanıcılar>  kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();

            kullanıcı1.Isim = "Gökhan";
            kullanıcı1.Soyisim ="Döktür";
            kullanıcı1.Yas = 32;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            
            kullanıcı2.Isim = "Deniz";
            kullanıcı2.Soyisim ="Döktür";
            kullanıcı2.Yas = 22;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Derya",
                Soyisim = "Döktür",
                Yas = 35
            });

            foreach(var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı:" + kullanıcı.Yas);
            }
            hayvanlarListesi.Clear();
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim {get => isim; set => isim = value;}
        public string Soyisim {get => soyisim; set => soyisim = value;}
        public int Yas {get => yas; set => yas = value;}

    }
}
