using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            arr = arr.Select(x => x * 1.2).ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine($"{item:F2}");
            }
            
        }
    }
}
