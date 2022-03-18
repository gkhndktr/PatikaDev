using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList  liste = new ArrayList();
            
/*             liste.Add("Gökhan");
            liste.Add(2);
            liste.Add(true);
            liste.Add('G');
 */
            //Verilere erişim.

/*             Console.WriteLine(liste[1]); */

/*             foreach (var item in liste)
            {
                Console.WriteLine(item);
            } */

            //AddRange
            Console.WriteLine("******Add Range*****");

            //string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1,8,4,59,2,49};

/*             liste.AddRange(renkler); */
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort

            Console.WriteLine("***Sort***");

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("***Binary Search***");

            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***Reverse***");
            liste.Reverse();

            //Clear
            Console.WriteLine("***Clear***");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
















                    }
    }
}
