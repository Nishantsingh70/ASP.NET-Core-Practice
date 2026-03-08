namespace Factorial_of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for which you want to factorial value : ");
            int n = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine(n);

            int number = fact(n);

            Console.WriteLine("Factorial number is " + number);

        }

        public static int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }
        }
    }
}
