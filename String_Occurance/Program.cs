using System.Security.Cryptography.X509Certificates;

namespace String_Occurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type any string :");
            string n = Console.ReadLine();

            Console.WriteLine("With Linq Syntax");
            withLinqSyntax(n);

            Console.WriteLine();

            Console.WriteLine("Without Linq Syntax");
            withoutLinqSyntax(n);

        }

        static void withLinqSyntax(string n)
        {
            if (n == null)
            {
                Console.WriteLine("String is null.");
            }
            else
            {
                var occurance = n.GroupBy(n => n).Select(g => new { character = g.Key, count = g.Count() });

                var occurance1 = from a in n
                                 group a by a into eGroup
                                 select new
                                 {
                                     character = eGroup.Key,
                                     count = eGroup.Count()
                                 };

                foreach (var c in occurance1)
                {
                    Console.WriteLine("character is " + c.character + " & count of it is " + c.count);
                }
            }
        }

        static void withoutLinqSyntax(string n)
        {
            if (n == null)
            {
                Console.WriteLine("String is null.");
            }
            else
            {
                Dictionary<char, int> frequency = new Dictionary<char, int>();

                foreach (char c in n)
                {
                    if (frequency.ContainsKey(c))
                    {
                        frequency[c]++;
                    }
                    else
                    {
                        frequency[c] = 1;
                    }

                }

                foreach(var c in frequency)
                {
                    Console.WriteLine("Character is " + c.Key + " & occurance of it is " + c.Value);
                }
            }
        }

            
    }
}
