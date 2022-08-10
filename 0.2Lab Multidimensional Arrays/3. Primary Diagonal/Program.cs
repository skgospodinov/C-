using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int row = i; row <= i; row++)
                {
                    for (int col = i; col <= i; col++)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);            
        }
    }
}
