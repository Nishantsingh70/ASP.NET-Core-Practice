namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number which you want to check the prime number :");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;

            Console.WriteLine(n);

            for (int i = 2; i < n / 2; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(n + " is a prime number");
                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                Console.WriteLine(n + " is not a prime number");
            }
        }
    }
}
