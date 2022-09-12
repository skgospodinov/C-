using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dresses = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputRow = Console.ReadLine().Split(new[] { " -> ","," },StringSplitOptions.RemoveEmptyEntries);
                string color = inputRow[0];
                string[] clothes = inputRow.Skip(1).ToArray();
                if (!dresses.ContainsKey(color))
                {
                    dresses.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothesWarderob = dresses[color];
                
                for (int j = 0; j < clothes.Length; j++)
                {
                    string currClothes = clothes[j];
                    if (!clothesWarderob.ContainsKey(currClothes))
                    {
                        clothesWarderob.Add(currClothes, 0);
                    }
                    clothesWarderob[currClothes]++;
                }
                
            }
            string[] findingClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var (color, dress) in dresses)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (item, count) in dress)
                {
                    if (findingClothes[0] == color && findingClothes[1] == item)
                    {
                        Console.WriteLine($"* {item} - {count} (found!)");
                    }
                    else 
                    {
                        Console.WriteLine($"* {item} - {count}");
                    }
                    
                }
            }
        }
    }
}
