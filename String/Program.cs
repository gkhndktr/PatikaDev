using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz c#, hoşgeldiniz!";
            string degisken2 = "Dersimiz c#";

            //Lenght -> stringin kaç karakter olduğunu söyler.
            Console.WriteLine(degisken.Length);
            
            //ToUpper ()-> Tüm karakterleri büyük yazdırır.
            //ToLower()-> Tüm karakterleri küçük yazdırır.
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());


            //Concat (degisken , eklemenmek istenen degisken )-> Verilen degerin sonuna ekleme yapar.
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));

            // Compare -> Parametre olarak verilen iki string ifadeyi karşılaştırır. geriye int döner. 
            //Eğer dönüş değeri 0 ise  iki metin birbirine eşittir. Eşit değilse, harf sırasına göre -1 ya da +1 döner.

            //CompareTo-> Büyük harf, küçük harf ve sıralaması kontrol edilir.
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.IndexOf("Gökhan"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));
            
            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("c#","c Sharp"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));
        }
    }
}
