using System;
using System.Collections.Generic;
namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(1, "Gökhan Döktür");
            kullanıcılar.Add(2, "Deniz Döktür");
            kullanıcılar.Add(3, "Derya Döktür");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***Elamanlara Erişim");
            Console.WriteLine(kullanıcılar[1]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("****Count****");
            Console.WriteLine(kullanıcılar.Count);

            //Contain
            Console.WriteLine("****Contain****");
            Console.WriteLine(kullanıcılar.ContainsKey(1));
            Console.WriteLine(kullanıcılar.ContainsValue("Gökhan"));

            //Remove
            Console.WriteLine("****Remove****");
            
            kullanıcılar.Remove(3);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("****Keys****");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }            
            //Values
            Console.WriteLine("****Keys****");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            } 


        }
    }
}
