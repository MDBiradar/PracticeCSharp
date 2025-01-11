using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class Recursion
    {
        public static void Factorial()
        {
            string? input;
            do{
                Console.WriteLine("Enter a number to find factorial: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int result = Factorial(n);
                Console.WriteLine("Factorial of " + n + "! is " + result);
                Console.WriteLine("Do you want to continue? (Y/N)");
                input = Console.ReadLine();
            } while((input == "Y" || input =="y")) ;
        }

        private static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n-1);
        }
    }
}
