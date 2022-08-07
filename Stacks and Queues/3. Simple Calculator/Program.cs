﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> expression = new Stack<string>(input.Reverse());

            while (expression.Count > 1) 
            {
                int leftNumber = int.Parse(expression.Pop());
                string sigh = expression.Pop();
                int rightNumber = int.Parse(expression.Pop());

                if (sigh == "-")
                {
                    expression.Push((leftNumber - rightNumber).ToString());
                }
                else if (sigh == "+")
                {
                    expression.Push((leftNumber + rightNumber).ToString());
                }
            }
            Console.WriteLine(expression.Pop());            
        }
    }
}
