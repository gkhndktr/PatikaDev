using System;
using System.Collections.Generic;

namespace Odev_1
{
    class Odev1
    {
        static void Main(string[] args)
        {

        /* 
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
            Console.WriteLine("Lütfen boyutu giriniz!");
            int number = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Lütfen rakam giriniz!");
                int eleman = int.Parse(Console.ReadLine());
                list.Add(eleman);
            }

            foreach (var item in list)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
