using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Sets_and_Dictionaries_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            

            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            
            foreach (var element in input) 
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element, 0);
                }
                dictionary[element] += 1;
            }
            foreach (var (key, value) in dictionary) 
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
