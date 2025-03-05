

using System.Collections;

namespace PracticeCSharp.CSharpPrograms
{
    internal class HashTableSearch
    {
        internal static void SearchForUnSortedArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Enter the number to search in the array: "+ string.Join(", ", array));
            int searchValue = Helper.GetValidNumber();

            bool IsFound = SearchForUnSortedArray(array, searchValue);
            Console.WriteLine(IsFound ? "Found" : "Not Found");
        }

        private static bool SearchForUnSortedArray(int[] array, int searchValue)
        {
            Hashtable hashTable = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                if (!hashTable.ContainsKey(array[i]))
                    hashTable[array[i]] = i;
            }

            if (hashTable.ContainsKey(searchValue))
                return true;
            else
                return false;

        }
    }
}