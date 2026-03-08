namespace Second_Largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 5, 1, 6, 3 };
            int largest = 0;
            int second_largest = 0;

            foreach (int i in arr) 
            {
                if(i > largest)
                {
                    second_largest = largest;
                    largest = i;
                }
                else if(i < largest && i > second_largest)
                {
                    second_largest = i;
                }
            }

            Console.WriteLine("Second Largest Number is :" + second_largest);

        }
    }
}
