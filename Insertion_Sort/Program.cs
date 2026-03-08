namespace Insertion_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 6, 3, 8, 4, 9 };

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j>=0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = key;
            }

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
