using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] juggedArr = new int[n][];
            for (int row = 0; row < juggedArr.Length; row++)
            {
                int[] rowArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                juggedArr[row] = rowArr;               
            }

            for (int row = 0; row < juggedArr.Length - 1; row++)
            {
                if (juggedArr[row].Length == juggedArr[row + 1].Length)
                {
                    juggedArr[row] = juggedArr[row].Select(n => n * 2).ToArray();
                    juggedArr[row + 1 ] = juggedArr[row + 1].Select(n => n * 2).ToArray();
                }
                else
                {
                    juggedArr[row] = juggedArr[row].Select(n => n / 2).ToArray();
                    juggedArr[row + 1] = juggedArr[row + 1].Select(n => n / 2).ToArray();
                }
            }

            string[] tokens = Console.ReadLine().Split();
            while (tokens[0] != "End")
            {
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (tokens[0] == "Add")
                {
                    if (row >= 0 && row < n && col>=0 &&col< juggedArr[row].Length)
                    {
                        juggedArr[row][col] += value;
                    }                   
                }
                if (tokens[0] == "Subtract")
                {
                    if (row >= 0 && row < n && col >= 0 && col < juggedArr[row].Length)
                    {
                        juggedArr[row][col] -= value;
                    }
                }
                tokens = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < juggedArr[row].Length; col++)
                {
                    Console.Write(juggedArr[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
