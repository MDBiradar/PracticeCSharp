

namespace PracticeCSharp.CSharpPrograms
{
    internal class BinarySearchSortedArray
    {
        internal static void BinarySearchExample()
        {
            SortedSet<int> sortedArray = [-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ];
            Console.WriteLine("List Element: "+string.Join(", ", sortedArray));
            Console.WriteLine("Please enter search element.");
            
            int input = Helper.GetValidNumber();

            int res = BinarySearchArray(sortedArray.ToArray(), input);
            Console.WriteLine();
            Console.WriteLine(res != -1 ? "Number Found, at index:"+res : "Number not Found");
        }

        private static int BinarySearchArray(int[] sArr, int tar)
        {
            int low = 0;
            int high = sArr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (sArr[mid] == tar)
                    return mid;
                else if (sArr[mid] < tar)
                    low = mid + 1;
                else
                    high = mid - 1;

            }
            return -1;
        }
    }
}