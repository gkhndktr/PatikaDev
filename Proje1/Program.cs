using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

            Console.WriteLine("****************");
            Console.WriteLine("Lütfen kişi adıın giriniz!");
            string kişi = Console.ReadLine();

            Contact kişi1 = new Contact(kişi);

            kişi1.Yazdır(kişi1.ToString());



        }
    }
}
