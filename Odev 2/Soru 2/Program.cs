using System;
using System.Collections;
namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve
            ortalama toplamlarını console'a yazdıran programı yazınız. 
            (Array sınıfını kullanarak yazınız.) */

            Console.WriteLine("20 adet sayı giriniz!");

            ArrayList liste = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                int check = Int32.Parse(Console.ReadLine());
                liste.Add(check);
            }
            liste.Sort();

            float ortMin = (float)(((int)liste[0] + (int)liste[1] + (int)liste[2])/3);
            float ortMax = (float)(((int)liste[^1] + (int)liste[^2] + (int)liste[^3])/3);


            Console.WriteLine(ortMin);
            Console.WriteLine(ortMax);
            Console.WriteLine(ortMax + ortMin);
        }
    }
}
