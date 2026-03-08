namespace Duplicate_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 2, 7, 1, 5 };

            Console.WriteLine("With Linq");
            WithLinq(arr);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Without Linq");
            WithoutLinq(arr);

        }

       public static void WithLinq(int[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                var duplicate = arr.GroupBy(x => x)
                                   .Where(g => g.Count() > 1)
                                   .Select(g => g.Key);

                var duplicate1 = from n in arr
                                 group n by n into eGroup
                                 where eGroup.Count() > 1
                                 select eGroup.Key;

                foreach (var e in duplicate1)
                {
                    Console.Write(e + " ");
                }
            }
        }

        public static void WithoutLinq(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                Dictionary<int, int> frequency = new Dictionary<int, int>();

                foreach(int i in arr)
                {
                    if (frequency.ContainsKey(i))
                    {
                        frequency[i]++;
                    }
                    else
                    {
                        frequency[i] = 1;
                    }
                }

                foreach(var i in frequency)
                {
                    if (frequency[i.Key] > 1)
                    {
                        Console.Write(i.Key + " ");
                    }
                }
            }

        }
    }
}
