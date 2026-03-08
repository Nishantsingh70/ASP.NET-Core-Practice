namespace Remove_Duplicate_from_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 5, 4, 1, 6 };

            Console.WriteLine("With Linq Syntax");
            withLinqSyntax(arr);

            Console.WriteLine();

            Console.WriteLine("Without Linq Syntax");
            withoutLinqSyntax(arr);
        }

        static void withLinqSyntax(int[] n)
        {
            if (n.Length == 0)
            {
                Console.WriteLine("Array is Empty");
            }
            else
            {
                var occurance = n.Distinct().ToArray();

                foreach (var c in occurance)
                {
                    Console.WriteLine("characters are " + c);
                }
            }
        }

        static void withoutLinqSyntax(int[] n)
        {
            if (n.Length == 0)
            {
                Console.WriteLine("Array is Empty");
            }
            else
            {
                List<int> frequency = new List<int>();

                foreach (int c in n)
                {
                    if (!frequency.Contains(c))
                    {
                        frequency.Add(c);

                    }
                }

                foreach (int c in frequency)
                {
                    Console.WriteLine("Characters are " + c);
                }
            }
        }


    }
}
