namespace Reverse_words_in_sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence : ");
            string n = Console.ReadLine();

            Console.WriteLine(n);
            Console.WriteLine("WithLinq");
            WithLinq(n);

            Console.WriteLine();

            Console.WriteLine("Without Linq");
            WithoutLinq(n);
        }

        public static void WithLinq(string n)
        {
            if(n.Length <= 0)
            {
                Console.WriteLine("String is null");
            }
            else
            {
                string temp = String.Join(" ", n.Split(" ").Select(x => new String(x.Reverse().ToArray())));
                Console.WriteLine(temp);
            }
        }

        public static void WithoutLinq(string n)
        {
            if (n.Length <= 0)
            {
                Console.WriteLine("String is null");
            }
            else
            {
                int length = n.Length;
                int start = 0;
                string reverse = "";
                for (int i = 0; i <= length; i++)
                {
                    if ( i == length || n[i] == ' ')
                    {
                        for (int j = i - 1; j >= start; j--)
                        {
                            reverse += n[j];
                        }

                        if (i < length)
                        {
                            reverse += " ";
                        }
                        start = i + 1;
                    }
                }

                Console.WriteLine(reverse);
            }
        }
    }
}
