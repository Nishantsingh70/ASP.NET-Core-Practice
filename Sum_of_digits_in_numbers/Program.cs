namespace Sum_of_digits_in_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            int digit = n.ToString().Length;

            Console.WriteLine(n);

            while(n > 0)
            {
                int rem = n % 10;
                temp = temp + rem;
               // temp = temp + (int)Math.Pow(rem, digit);
                n = n / 10;
            }

            Console.WriteLine("Sum of digits in number is : " + temp);
        }
    }
}
