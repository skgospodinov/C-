using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (!dictionary.ContainsKey(currChar))
                {
                    dictionary.Add(currChar, 0);
                }
                dictionary[currChar]++;                               
            }
            foreach (var (ch, count) in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{ch}: {count} time/s");
            }
        }
    }
}
