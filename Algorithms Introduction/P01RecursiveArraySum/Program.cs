using System;

namespace P01RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            int sum = Sum(numbers, 0);

            Console.WriteLine(sum);
        }

        private static int Sum(int[] numbers, int startIndex)
        {
            if (startIndex == numbers.Length - 1)
            {
                return numbers[startIndex];
            }
            return numbers[startIndex] + Sum(numbers, startIndex + 1);
        }
    }
}
