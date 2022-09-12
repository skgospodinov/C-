using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Sum());
        }
    }
}
