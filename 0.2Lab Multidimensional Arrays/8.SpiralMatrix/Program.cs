using System;

namespace _8.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 0; i < n*n; i++)
            {                
                matrix[row, col] = i + 1;
                
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }

                if ((col == n || IsValid(row,col,matrix,n)) && direction == "right") 
                {
                    col--;
                    row++;
                    direction = "down";
                }
                if ((row == n || IsValid(row, col, matrix, n)) && direction == "down")
                {
                    col--;
                    row--;
                    direction = "left";
                }
                if ((col == -1 || IsValid(row, col, matrix, n)) && direction == "left")
                {
                    col++;
                    row--;
                    direction = "up";
                }
                if ((row == -1 || IsValid(row, col, matrix, n)) && direction == "up")
                {
                    col++;
                    row++;
                    direction = "right";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] < 10)
                    {
                        Console.Write(" " + matrix[i, j] + " ");
                    }
                    else 
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int row, int col, int[,] matrix, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n && matrix[row, col] != 0;
        }
    }
}
