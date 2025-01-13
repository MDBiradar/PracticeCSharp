using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal class Helper
    {
        public static void GetValidNumber(out int searchValue)
        {
            bool isValid = int.TryParse(Console.ReadLine(), out searchValue);
            while (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                isValid = int.TryParse(Console.ReadLine(), out searchValue);
            }
        }
    }
}
