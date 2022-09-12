using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Action<List<string>> printName = n => Console.WriteLine(string.Join(Environment.NewLine,names));
            printName(names);
        }
    }
}
