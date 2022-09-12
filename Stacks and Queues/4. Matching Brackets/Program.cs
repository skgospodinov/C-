﻿using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> expression = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    expression.Push(i);
                }
                if (input[i] == ')') 
                {
                    int startIndex = expression.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex +1));
                }
            }
        }
    }
}
