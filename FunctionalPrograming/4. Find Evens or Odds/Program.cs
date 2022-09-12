using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = arr[0];
            int endIndex = arr[1];
            string criteria = Console.ReadLine();

            List<int> numbers = Enumerable.Range(startIndex, endIndex - startIndex + 1).ToList();
            Func<int, bool> predicate = GetType(criteria);

            Console.WriteLine(string.Join(" ", numbers.Where(predicate)));            
        }

        //static List<int> MyWhere(List<int> numbers, Func<int, bool> predicate)
        //{
        //    List<int> newNumbers = new List<int>();
        //
        //    foreach (var num in numbers)
        //    {
        //        if (predicate(num))
        //        {
        //            newNumbers.Add(num);
        //        }
        //    }
        //    return newNumbers;
        //}

        static Func<int, bool> GetType(string criteria)
        {
            Func<int, bool> predicate = n => true;
            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }
            return predicate;
        }
    }
}
