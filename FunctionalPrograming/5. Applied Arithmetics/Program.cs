using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Func<int, int>> aritmeticFunctions = new Dictionary<string, Func<int, int>>()
            {
                {"add", num => num + 1},
                {"multiply", num => num * 2},
                {"subtract", num => num - 1}
            };

            List<int>  numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                if (aritmeticFunctions.ContainsKey(command))
                {
                    Func<int, int> func = aritmeticFunctions[command];
                    numbers = numbers.Select(func).ToList();
                }
                else if (command == "print") 
                {
                    print(numbers);
                }

               //if (command == "print")
               //{
               //    print(numbers);
               //}
               //else
               //{
               //    Func<int, int> aritmeticFunc = GetAritmeticFunction(command);
               //    numbers = numbers.Select(aritmeticFunc).ToList();
               //}
                command = Console.ReadLine();
            }

            //static Func<int,int> GetAritmeticFunction(string command) 
            //{
            //    Func<int, int> aritmeticFunc = num => num;
            //    if (command == "add")
            //    {
            //        aritmeticFunc = num => num + 1;
            //        
            //    }
            //    else if (command == "multiply")
            //    {
            //        aritmeticFunc = num => num * 2;
            //        
            //    }
            //    else if (command == "subtract")
            //    {
            //        aritmeticFunc = num => num - 1;
            //        
            //    }
            //   return aritmeticFunc;
            //}
        }
    }
}
