namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 1;
            int n = 10;

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                int c = a + b;

                Console.Write(c + " ");

                a = b;
                b = c;
            }


        }
    }
}
