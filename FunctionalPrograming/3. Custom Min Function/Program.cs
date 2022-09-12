using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> printSmallestNumber = FindMin;           
            Console.WriteLine(printSmallestNumber(arr));
        }

        public static int FindMin(List<int> arr) 
        {
            return arr.Min();
        }
    }
}
