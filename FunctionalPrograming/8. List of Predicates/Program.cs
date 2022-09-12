using System;
using System.Linq;

namespace _8._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(arr, (a, b) =>
            {
                if (a % 2 != 0 && b% 2== 0)
                {
                    return 1;
                }
                else if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                int temp = a.CompareTo(b);
                return temp;
            });
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
