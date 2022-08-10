using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            string[] input = Console.ReadLine().Split();

            while (input[0].ToLower() != "end") 
            {
                if (input[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(input[1]));
                    stack.Push(int.Parse(input[2]));
                }
                else if (input[0].ToLower() == "remove") 
                {
                    if (int.Parse(input[1]) < stack.Count)
                    {
                        for (int i = 0; i < int.Parse(input[1]); i++)
                        {
                            stack.Pop();
                        }
                    }                   
                }
                input = Console.ReadLine().Split();
            }
            int sum = 0;
            foreach (var el in stack)
            {
                sum += el;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
