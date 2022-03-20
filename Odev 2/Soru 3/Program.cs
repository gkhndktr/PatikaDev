using System;
using System.Collections;
namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri 
            bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. */
            Console.WriteLine("Lütfen bir cümle giriniz!");
            string check = Console.ReadLine();
            ArrayList liste = new ArrayList();

            foreach (var item in check)
            {
                if(item != ' ')
                {
                    if ("aeıioöuü".Contains(item))
                    {
                        liste.Add(item);
                    }
                }
            }
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}
