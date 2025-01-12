using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal class IsPrimeNumber
    {
        public static void IsPrime()
        {
            do
            {
                Console.WriteLine("Enter a number to check if it is a prime number or not: ");
                int num = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;

                if(num == 0 || num == 1)
                    isPrime = false;
                else if (num == 2 || num == 3)
                    isPrime = false;
                else if (num % 2 == 0 || num % 3 == 0)                
                    isPrime = false;
                
                Console.WriteLine(isPrime ? $"{num} is prime" : $"{num} is not prime");
                Console.WriteLine("Do you want to continue? (Y/N)");
            } while (Console.ReadLine()?.ToUpper() != "Y");
        }
    }
}
