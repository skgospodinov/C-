using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums[0];
            int s = nums[1];
            int x = nums[2];
            Queue<int> queue = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else 
            {
                if (queue.Contains(x)) 
                {
                    Console.WriteLine("true");
                }
                else 
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
