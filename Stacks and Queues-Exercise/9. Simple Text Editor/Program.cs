using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];

                switch (action)
                {
                    case "1":
                        sb.Append(commands[1]);
                        stack.Push(sb.ToString());
                        break;
                    case "2":
                        int number = int.Parse(commands[1]);
                        sb.Remove(sb.Length -number, number);
                        stack.Push(sb.ToString());
                        break;
                    case "3":
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(sb[index - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        sb = new StringBuilder();
                        sb.Append(stack.Peek());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
