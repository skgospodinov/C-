using System;
using System.Linq;

namespace Exercise_Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int sumLeft = 0;
            int cnt = 0;

            for (int row = 0; row < n; row++)
            {
                sumLeft += matrix[row, cnt];
                cnt++;
            }

            int sumRight = 0;
            int count = n-1;

            for (int row = 0; row < n; row++)
            {
                sumRight += matrix[row, count];
                count--;
            }
            Console.WriteLine(Math.Abs(sumLeft - sumRight));
        }

    }
}

