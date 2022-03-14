using System;
using System.Collections.Generic;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */
        Console.WriteLine("Lütfen boyutu giriniz!");
        int boyut = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen kontrol sayısını giriniz!");
        int kontrol = int.Parse(Console.ReadLine());

        List<int> liste = new List<int>();

        for (int i = 0; i < boyut; i++)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int eleman = int.Parse(Console.ReadLine());

            if(eleman <=0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                i--;
                continue;
            }
            liste.Add(eleman);
        }

        foreach (var item in liste)
        {
            if(item % kontrol == 0 || item == kontrol)
            {
                Console.WriteLine(item);
            }
        }

        }
    }
}
