using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantinty = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orderQueue = new Queue<int>(orders);
            Console.WriteLine(orderQueue.Max());

            while (orderQueue.Count > 0)
            {
                if (foodQuantinty < orderQueue.Peek())
                {
                    break;
                }
                foodQuantinty -= orderQueue.Dequeue();
                

            }
            if (orderQueue.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orderQueue)}");
            }

        }
    }
}
