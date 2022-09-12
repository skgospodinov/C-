﻿using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    long sum = 0;
                    if (row - 1 >= 0 && col < pascalTriangle[row - 1].Length)
                    {
                        sum += pascalTriangle[row - 1][col];
                    }
                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += pascalTriangle[row - 1][col - 1];
                    }
                    if (row == 0)
                    {
                        sum = 1;
                    }
                    pascalTriangle[row][col] = sum;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write(pascalTriangle[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
