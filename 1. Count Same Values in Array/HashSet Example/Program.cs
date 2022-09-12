using System;
using System.Collections.Generic;

namespace HashSet_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string contry = input[1];
                string city = input[2];

                if (!dictionary.ContainsKey(continent)) 
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                }
                
                if (!dictionary[continent].ContainsKey(contry)) 
                {
                    dictionary[continent].Add(contry, new List<string>());
                }
                dictionary[continent][contry].Add(city);                
            }
            
            foreach (var (continent, country) in dictionary)
            {
                Console.WriteLine($"{continent}: ");

                foreach (var (count, city) in country) 
                {
                    Console.WriteLine($"    {count} -> {string.Join(", ", city)}");                    
                }               
            }
        }
    }
}
