namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 2, 8, 1, 7, 2, 9, 7 };

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr.Length - i -1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                  
                    }
                }
            }
            foreach(int n in arr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
