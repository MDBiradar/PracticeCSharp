using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal class Helper
    {
        public static int GetValidNumber()
        {            
            bool isValid = int.TryParse(Console.ReadLine(), out int searchValue);
            while (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                isValid = int.TryParse(Console.ReadLine(), out searchValue);
            }
            return searchValue;
        }
    }
}
