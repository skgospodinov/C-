using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();
            //Func<int, bool> predicate = num => num % n != 0;
            //numbers = numbers.Where(predicate).ToList();
            Func<int, bool> predicate = num => num % n != 0;
            numbers = MyWhere(numbers,predicate);
            Action<List<int>> action = nums => Console.WriteLine(string.Join(" ", nums));
            action(numbers);
        }

        static List<int> MyWhere(List<int> numbers, Func<int, bool> predicate) 
        {
            List<int> newNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (predicate(num)) 
                {
                    newNumbers.Add(num);
                }
            }
            return newNumbers;
        }
    }
}
