using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz!");


            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayac; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);

            }

            // 1 ile 100 arasındaki tek ve çift sayıların kendi aralarında toplamlarını ekrana yazdırın.

            int tektoplam = 0;
            int cifttoplam = 0;

            for (int i = 0; i < 1000; i++)
            {
                if(i % 2 == 0)
                    tektoplam +=1; //tektoplam = tektoplam + 1
                else
                    cifttoplam += 1; //cifttoplam = cifttoplam +1
            }
            Console.WriteLine("tek toplam: " + tektoplam);
            Console.WriteLine("çift topoam: " + cifttoplam);

            // break 

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            
            //continue
            
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

        }
    }
}
