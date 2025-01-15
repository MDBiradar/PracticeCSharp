using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal class PrimeNumber
    {
        public static void IsPrimeNumber()
        {
            do
            {
                Console.WriteLine("Enter a number to check if it is a prime number or not: ");
                int num = Helper.GetValidNumber();
                bool isPrime = IsPrime(num);
                Console.WriteLine(isPrime ? $"{num} is prime" : $"{num} is not prime");
                Console.WriteLine("Do you want to continue? (Y/N)");
            } while (Console.ReadLine()?.ToUpper() == "Y");
        }

        private static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
