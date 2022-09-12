using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums[0];
            int s = nums[1];
            int x = nums[2];
            Stack<int> stack = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                
                stack.Push(input[i]);               
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count== 0)
            {
                Console.WriteLine(0);
            }
            else 
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
