using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = FillTheMatrix(matrixSize);
            FindTheSquare(matrix, m);
        }

        private static void FindTheSquare(int[,] matrix, int m)
        {
            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - m + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - m + 1; col++)
                {
                    int currSum = 0;
                    //int currSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    for (int squareRow = row; squareRow < row + m; squareRow++)
                    {
                        for (int squareCol = col; squareCol < col + m; squareCol++)
                        {
                            currSum += matrix[squareRow, squareCol];
                        }
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }
            PrintResult(maxSumRow, maxSumCol, m, matrix, maxSum);
        }

        private static int[,] FillTheMatrix(int[] n)
        {
            int[,] matrix = new int[n[0], n[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] arrToRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrToRow[col];
                }
            }
            return matrix;
        }

        private static void PrintResult(int maxSumRow, int maxSumCol, int m, int[,] matrix, int maxSum)
        {
            for (int row = maxSumRow; row < maxSumRow + m; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}

