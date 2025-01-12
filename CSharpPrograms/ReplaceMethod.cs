using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class ReplaceMethod
    {
        public static void ReplaceString()
        {
            string userInput;
            do
            {
                Console.WriteLine("Enter a string value: ");
                string s = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter substring value you want to replace with: ");
                string oldSubstring = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter new value you want to replace: ");
                string newSubstring = Console.ReadLine() ?? string.Empty;
                string result = ReplaceSubstring(s, oldSubstring, newSubstring);
                Console.WriteLine($"New string: {result}");
                
                Console.WriteLine("Do you want to continue? Enter Y/N: ");
                userInput = Console.ReadLine() ?? string.Empty;
            } while (userInput =="Y" || userInput == "y");
            
        }

        public static string ReplaceSubstring(string s, string oldSubstring, string newSubstring)
        {
            int i = 0;
            var oldLen = oldSubstring.Length;           
            string result = string.Empty;
            bool found = false;

            while (i < s.Length)
            {
                if((i + oldLen) <= s.Length && s.Substring(i, oldLen) == oldSubstring)
                {
                    result += newSubstring;
                    i += oldLen;
                    found = true;
                }
                else
                {
                    result += s[i];
                    i++;
                }
            }
            return found ? result : s;
        }
            
    }
}
