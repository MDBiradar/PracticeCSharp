

namespace PracticeCSharp.CSharpPrograms
{
    internal class MergeSortedArray
    {
        internal static void MergeArraysExample()
        {
            SortedSet<int> arr1 = [6, 4, 3, 1];
            SortedSet<int> arr2  = [9, 8, 4, 5];

            var mergedArray = MergeSortArray(arr1.ToArray(), arr2.ToArray());
            Console.WriteLine("Merged Array: "+string.Join(", ", mergedArray));

        }

        private static int[] MergeSortArray(int[] arr1, int[] arr2)
        {
            int[] res = new int[(arr1.Length + arr2.Length)];
            int i=0, j= 0, k = 0;
            while (i< arr1.Length && i < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    res[k++] = arr1[i++];
                }
                else
                {
                    res[k++] = arr2[j++];
                }               
            }

            while (i < arr1.Length)
            {
                res[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                res[k++] = arr2[j++];
            }
            return res;
        }
    }
}