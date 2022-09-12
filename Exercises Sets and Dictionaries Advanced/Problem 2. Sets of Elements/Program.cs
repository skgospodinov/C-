using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> thirdSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }
            for (int i = 0; i < m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondSet.Add(input);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    thirdSet.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",thirdSet));
        }
    }
}
