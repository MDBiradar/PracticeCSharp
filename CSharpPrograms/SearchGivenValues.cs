


namespace PracticeCSharp.CSharpPrograms
{
    internal class SearchGivenValues
    {
        internal static void SearchValues()
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
                Console.WriteLine("Enter the value to search: ");
                int searchValue = Helper.GetValidNumber();
                Console.WriteLine(Found(arr, searchValue) ? "Number Found" : "Not Found");                
                Console.WriteLine("Do you want to continue? (Y/N)");
            } while (Console.ReadLine()?.ToUpper() == "Y");
        }

        private static bool Found(int[] arr, int searchValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchValue)
                {
                    return true;
                }
            }
            return false;
        }  
    }
}