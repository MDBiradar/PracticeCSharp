using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class FibonacciSeries
    {
        public static void FibonacciNumber()
        {
            
            string userInput = string.Empty;
            do {
                Console.WriteLine("Enter a number to show fibonacci series");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fibonacci series is: ");
                var result = GetFibonacciWithYeild(num);
                foreach(int i in result)
                {
                    Console.Write(i + " ");
                }                

            } while ((userInput == "Y" || userInput == "y"));


        }

        //performance and better memory use
        private static IEnumerable<int> GetFibonacciWithYeild(int num)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < num; i++)
            {
                yield return a;
                int temp = a;
                a = b;
                b += temp;

            }
        }

        private static int[] GetFibonacciWithArreay(int num)
        {
            int[] result = new int[num];
            if (num > 0) result[0] = 0;
            if (num > 1) result[1] = 1;
            for (int i = 2; i < num; i++)
            {
                result[i] = result[i-1] + result[i - 2];
            }
            return result;
        }
    }
}
