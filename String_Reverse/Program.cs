namespace String_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter the string :");
            string n = Console.ReadLine();

            Console.WriteLine("Reverse the string with Linq Syntax");
            WithLinq(n);

            Console.Write('\n');

            Console.WriteLine("Reverse the string without Linq Syntax.");
            WithoutLinq(n);
        }

        static void WithLinq(string n)
        {
            string key = n;
            if (n == null)
            {
                Console.WriteLine("String is null");
            }
            else
            {
                var reverse = new string(n.Reverse().ToArray());
                Console.WriteLine("Reverse string is " + reverse);

                if (key == reverse)
                {
                    Console.WriteLine("String is Palindrome");
                }
            }

        }

        static void WithoutLinq(string n)
        {
            if (n == null)
            {
                Console.WriteLine("String is null");
            }
            else
            {
                int length = n.Length;
                string reverse_string = "";

                for (int i = length - 1; i >= 0; i--)
                {
                    reverse_string += n[i];
                }

                Console.WriteLine("Reverse string is " + reverse_string);

                if (n == reverse_string)
                {
                    Console.WriteLine("String is Palindrome");
                }

            }


        }
    }
}
