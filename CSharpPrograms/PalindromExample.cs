using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class PalindromExample
    {
        public static void Palindrom()
        {
            string userInput;
            do
            {
                Console.WriteLine("Enter a value: ");
                string input = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (input.Reverse().SequenceEqual(input))
                        Console.WriteLine("Is Palidrom");
                    else
                        Console.WriteLine("Not Palidrom");
                }
                Console.WriteLine("Do you want to continuez? Enter Y/N: ");
                userInput = Console.ReadLine() ?? string.Empty;
            } while (userInput == "Y" || userInput == "y");
                        
        }
        public static void PalindromNoInbuildMethod()
        {
            string userInput;
            do
            {
                Console.WriteLine("Enter a value: ");
                string input = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (IsPalindrom(input))
                        Console.WriteLine("Is Palidrom");
                    else
                        Console.WriteLine("Not Palidrom");
                }
                Console.WriteLine("Do you want to continuez? Enter Y/N: ");
                userInput = Console.ReadLine() ?? string.Empty;
            } while (userInput == "Y" || userInput == "y");

        }

        private static bool IsPalindrom(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
