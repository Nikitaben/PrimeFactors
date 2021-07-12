using System;
using System.Linq;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class Program
    {
        public static string primeFactors(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div <= 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }
            return string.Join(" x ", primes);

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Prime Factors of 4 are: " + primeFactors(4));
            Console.WriteLine($"Prime Factors of 7 are: " + primeFactors(7));
            Console.WriteLine($"Prime Factors of 30 are: " + primeFactors(30));
            Console.WriteLine($"Prime Factors of 40 are: " + primeFactors(40));
            Console.WriteLine($"Prime Factors of 50 are: " + primeFactors(50));
        }
    }
}