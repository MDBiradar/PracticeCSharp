using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class SortStrings
    {
        public static void SortStringAlphabets()
        {
            string? input = Console.ReadLine();
            char[] arr = input != null ? input.ToCharArray() : [];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void SplitString()
        {
            string? input = Console.ReadLine();
            if (input == null)
                return;

            List<string> result = [];
            int start = 0;            
            for (int i = 0; i <= input.Length; i++) 
            {               
                if (i == input.Length || input[i] == ' ')
                {                   
                    result.Add(input[start..i].Trim());
                    start = i;
                }
            }

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
