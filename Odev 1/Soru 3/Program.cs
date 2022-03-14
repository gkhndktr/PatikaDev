using System;
using System.Collections.Generic;
namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın */

        Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen {0} adet kelime giriniz", number);
        List<string> liste = new List<string>();

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Lütfen bir kelime giriniz!");
            string kelime = Console.ReadLine();
            liste.Add(kelime);
        }

        liste.Reverse();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        }
    }
}
