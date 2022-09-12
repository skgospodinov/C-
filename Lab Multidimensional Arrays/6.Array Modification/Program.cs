using System;
using System.Linq;

namespace _6.Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            matrix = ReadMatrix(matrix);
            matrix = MatrixManipulation(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }

        private static int[,] MatrixManipulation(int[,] matrix)
        {
            string[] tokens = Console.ReadLine().Split();
            while (tokens[0] != "END")
            {
                int rowIndex = int.Parse(tokens[1]);
                int colIndex = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if ((rowIndex >= 0 && rowIndex < matrix.GetLength(0)
                        && colIndex >= 0 && colIndex < matrix.GetLength(1)))
                {
                    if (tokens[0] == "Add")
                    {
                        matrix[rowIndex, colIndex] += value;
                    }
                    else if (tokens[0] == "Subtract")
                    {
                        matrix[rowIndex, colIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                tokens = Console.ReadLine().Split();
            }
            return matrix;
        }
    }
}
