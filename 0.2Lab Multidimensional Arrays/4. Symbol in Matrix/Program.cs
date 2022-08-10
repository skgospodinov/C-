using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            bool isConsist = false;
            int indexRow = 0;
            int indexCol = 0;
            char symbol = Console.ReadLine()[0];

            for (int row = 0; row < n; row++)
            {
                if (isConsist)
                {
                    break;
                }
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isConsist = true;
                        indexRow = row;
                        indexCol = col;
                        break;
                    }                 
                }
            }

            if (isConsist)
            {
                Console.WriteLine($"({indexRow},{indexCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
