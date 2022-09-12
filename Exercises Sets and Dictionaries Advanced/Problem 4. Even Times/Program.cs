using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            int count = 1;
            int number = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (set.Contains(input))
                {
                    count++;
                    number = input;
                }               
                set.Add(input);
            } 
            
            if(count > 1 && count % 2== 0 && number !=int.MinValue)
            {
                Console.WriteLine(number);
            }
        }
    }
}
