using System;
using System.Collections;
using System.Linq;
namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)

    Negatif ve numeric olmayan girişleri engelleyin.

 */

            ArrayList primeNumbers = new ArrayList();
            ArrayList NonPrimeNumbers = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                uint number;
                Console.WriteLine("Kindly provide a positive integer value");
                if (uint.TryParse(Console.ReadLine(), out number))
                {
                    if (number == 1)
                    {
                        NonPrimeNumbers.Add(number);
                        /*                     Console.WriteLine("1 is not a prime number"); */
                        continue;
                    }
                    if (number == 2)
                    {
                        primeNumbers.Add(number);
                        /*                     Console.WriteLine("2 is a prime number"); */
                        continue;
                    }

                    for (int j = 2; j < number; j++)
                    {
                        if (number % j == 0)
                        {
                            NonPrimeNumbers.Add(number);
                            /*                         Console.WriteLine(number + " is not a prime number"); */
                            break;
                        }
                        if (j == number - 1)
                        {
                            primeNumbers.Add(number);
                            /*                         Console.WriteLine( number +" is a prime number"); */
                        }
                    }
                }
                else
                {
                    i--;
                    Console.WriteLine("Kindly provide pozitive integer value");
                }
            }
            /*     Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. */
            primeNumbers.Sort();
            NonPrimeNumbers.Sort();
            primeNumbers.Reverse();
            NonPrimeNumbers.Reverse();
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item + " is a prime number!");
            }
            foreach (var item in NonPrimeNumbers)
            {
                Console.WriteLine(item + " is not a prime number");
            }


            uint totalPrime = 0;
            foreach (uint item in primeNumbers)
            {
                totalPrime += item;
            }
            float primeCount = (float)primeNumbers.Count;
            Console.WriteLine("Count of  prime numbers is: " + primeCount.ToString("0.0###"));

            try
            {
                float primeAverage = totalPrime / primeNumbers.Count;
                Console.WriteLine("Average of prime numbers is: " + primeAverage.ToString("0.0###"));
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("You have not provided any prime number");
                Console.WriteLine(e.Message);
            }

            uint totalNonPrime = 0;
            foreach (uint item in NonPrimeNumbers)
            {
                totalNonPrime += item;
            }
            float nonPrimeCount = (float)NonPrimeNumbers.Count;
            Console.WriteLine("Count of non prime numbers is: " + nonPrimeCount.ToString("0.0###"));
            try
            {

                float nonPrimeaverage = totalNonPrime / NonPrimeNumbers.Count;
                Console.WriteLine("Average of non prime numbers is: " + nonPrimeaverage.ToString("0.0###"));
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("You have not provided any non prime number");
                Console.WriteLine(e.Message);
            }

    }
    }
}
