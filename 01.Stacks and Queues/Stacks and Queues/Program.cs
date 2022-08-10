using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Stack<char> revercedStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                revercedStack.Push(input[i]);
            }
            foreach(var ch in revercedStack)
            {
                Console.Write( ch );
            }
            
        }
    }
}
