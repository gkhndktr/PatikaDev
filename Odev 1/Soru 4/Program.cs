using System;
using System.Collections.Generic;
namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

        Console.WriteLine("Lütfen bir cümle yazınız!");
        string[] kelimeler = Console.ReadLine().Split(" ");
        int kelimeSayisi = kelimeler.Length;
        Console.WriteLine("Kelime sayısı: " + kelimeSayisi);
        
        int harfSayisi = 0;
 
        foreach (var kelime in kelimeler)
        {
            harfSayisi += kelime.ToCharArray().Length;
            
        }

        Console.WriteLine("Harf sayısı: "+ harfSayisi);
        }
    }
}
