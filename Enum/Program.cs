using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);
            Console.WriteLine("Hava sıcaklığını giriniz");
            int sıcaklık = Int32.Parse(Console.ReadLine());

            if ( sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava soğuk");

            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Hava sıcak");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Hava güzel");
            }
        }


    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {   
        Soğuk = 5,
        Normal = 20,

        Sıcak = 25,
        ÇokSıcak = 30,
    }
}
