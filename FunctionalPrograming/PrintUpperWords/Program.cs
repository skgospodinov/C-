using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintUpperWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = x => Char.IsUpper(x[0]);
            string text = Console.ReadLine();
            string[] words = text.Split();

            words = words.Where(filter).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
