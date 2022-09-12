using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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
                string[] arr = Console.ReadLine().Split();
                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
            string[] tokens = Console.ReadLine().Split();
            while (tokens[0] != "END")
            {
                if (!IsValid(tokens,rowSize, colSize))
                {
                    string command = tokens[0];
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);

                    string buffer = "";
                    buffer = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = buffer;

                    for (int row = 0; row < rowSize; row++)
                    {
                        for (int col = 0; col < colSize; col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                tokens = Console.ReadLine().Split();
            }
        }
        private static bool IsValid(string[] tokens, int rowSize, int colSize)
        {
            return tokens[0] != "swap" || tokens.Length != 5 || int.Parse(tokens[1]) < 0 ||
                   int.Parse(tokens[1]) > rowSize || int.Parse(tokens[2]) < 0 || int.Parse(tokens[2]) > colSize ||
                   int.Parse(tokens[3]) < 0 || int.Parse(tokens[3]) > rowSize || int.Parse(tokens[4]) < 0 ||
                   int.Parse(tokens[4]) > colSize;
        }
    }
}
