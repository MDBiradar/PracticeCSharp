
namespace PracticeCSharp.CSharpPrograms
{
    internal class FindDuplicate
    {
        public static void FindDuplicates()
        {
            do
            {
                Console.WriteLine("Enter the number of elements in the array: ");
                int n = Helper.GetValidNumber();                    
                int[] arr = new int[n];
                Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < n; i++)
                {
                    int input = Helper.GetValidNumber();
                    arr[i] = input;
                }
                Console.WriteLine("The duplicate elements in the array are: ");
                List<int> duplicates = FindDuplicateNumbers(arr);
                duplicates.ForEach(i => Console.WriteLine(i));
                Console.WriteLine("Do you want to continue? (Y/N)");
            } while (Console.ReadLine()?.ToUpper() == "Y");
        }
        private static List<int> FindDuplicateNumbers(int[] arr)
        {
            HashSet<int> set = [];
            List<int> duplicates =[];
            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                {
                    duplicates.Add(arr[i]);
                }
            }
            return duplicates;
        }
    }
}