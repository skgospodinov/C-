using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenNumbers.Enqueue(arr[i]);
                }
            }
            while (evenNumbers.Count > 1)
            {

                Console.Write($"{evenNumbers.Dequeue()}, ");

            }
            Console.Write(evenNumbers.Peek());
        }
    }
}
