using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];
            string[,] matrix = new string[rowSize, colSize];

            for (int row = 0; row < rowSize; row++)
            {
                string[] rowArr = Console.ReadLine().Split();
                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = rowArr[col];
                }
            }
            int count = 0;

            for (int row = 0; row < rowSize - 1; row++)
            {
                for (int col = 0; col < colSize - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
