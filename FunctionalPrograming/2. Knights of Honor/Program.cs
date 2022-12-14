using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> newNames = names.Select(x => $"Sir {x}").ToList();

            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printNames(newNames);
            printNames(names);
        }
    }
}
