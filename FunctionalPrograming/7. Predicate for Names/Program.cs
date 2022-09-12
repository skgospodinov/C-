using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> func = (name, lenght) => name.Length <= lenght;

            names = names.Where(name => func(name, lenght)).ToList();

            Action<List<string>> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            print(names);
        }
    }
}
