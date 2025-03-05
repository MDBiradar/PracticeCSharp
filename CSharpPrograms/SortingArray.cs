using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    public class SortingArray
    {
        public static void SortInteger()
        {
            int[] nums = [10, 6, 9, 7, 2, 1, 3, 4];

            SortLogic(nums); 
            ShuffleNumbers(nums);
            SortLogic(nums);
            ShuffleNumbers(nums);
           
        }

        private static void PrintsNumbers(int[] nums)
        {
            Console.WriteLine("Array Numers:");
            foreach (int i in nums)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        private static void SortLogic(int[] nums)
        {
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }

                }
            }
            PrintsNumbers(nums);
        }

        private static void ShuffleNumbers(int[] nums)
        {
            var random = new Random();          

            for (int i = nums.Length -1 ; i > 0 ; i--)
            {
                int j = random.Next(i);
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            PrintsNumbers(nums);
        }

    }
}
