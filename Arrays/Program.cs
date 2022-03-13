using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int [] sayiDizisi = {23,12,86,72,3,11,17};

            Console.WriteLine("*****Sırasız liste*****");
            foreach (var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi) ;
            }

            Console.WriteLine("*****Sıralı Liste*****");

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi) ;
            }

            //Clear
            Console.WriteLine("*****Array Clear*****");
            //Sayı dizisi elemanlarını kullanarak belirtili indexten başlayarak verilen input kadar sıfırlar.


            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi) ;
            }

            //Reverse
            Console.WriteLine("*****Array Reverse*****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi) ;
            }
            

            //Indexof
            Console.WriteLine("*****Array Indexof*****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            //resize
            Console.WriteLine("*****Array Resize*****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi) ;
            } 

            
        }
    }
}
