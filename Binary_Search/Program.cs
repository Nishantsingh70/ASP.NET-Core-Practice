namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 7, 8 };

            int left = 0;
            int right = arr.Length;
            int target = 3;
            //bool flag = false;

            if(arr == null)
            {
                Console.WriteLine("Array is empty.");
            }

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    Console.WriteLine("Find the number at " + mid + " position.");
                    //flag = true;
                    break;
                }
                else
                {
                    if (arr[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

        }
    }
}
