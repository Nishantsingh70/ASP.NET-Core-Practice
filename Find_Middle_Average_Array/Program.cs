namespace Find_Middle_Average_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 2, 5, 1, 6, 3 };
            int[] arr1 = { 1, 2, 3, 4, 5,6 };

            if (arr.Length == 0)
            {
                Console.WriteLine(" Array is empty! Please enter valid array! ");
            }

            int[] sorted = arr.OrderBy(x => x).ToArray();

            int length = sorted.Length;
            if(length % 2 == 1)
            {
                double sum = sorted[length / 2];
                Console.WriteLine("Middle value is test : " + sum);
            }
            else
            {
                if(length % 2 == 0) 
                {
                    double sum = (sorted[(length / 2)-1] + sorted[length / 2]) / 2.0;
                    Console.WriteLine("Middle value is : " + sum);
                }
            }
        }
    }
}
