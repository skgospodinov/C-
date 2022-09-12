using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];
            char[,] matrix = new char[rowSize, colSize];
            string direction = "right";
            int row = 0;
            int col = 0;
            int count = 0;

            for (int i = 0; i < rowSize * colSize; i++)
            {
                if (count <= snake.Length)
                {
                    matrix[row, col] = snake[count];
                    count++;
                }
                if (count == snake.Length)
                {
                    count = 0;
                }              
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (col == colSize && direction == "right")
                {
                    col--;
                    row++;
                    direction = "left";
                }
                if (col < 0 && direction == "left")
                {
                    col++;
                    row++;
                    direction = "right";
                }
            }
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
