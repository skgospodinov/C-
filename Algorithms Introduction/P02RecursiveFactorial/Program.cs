using System;

namespace P02RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Factorial(n)); 

        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
