using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string[] tokens = Console.ReadLine().Split(" ");

            while (tokens[0] != "End") 
            {
                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                
                if (command == "Shoot")
                {
                    if (index >= 0 && index < arr.Count)
                    {
                        arr[index] -= value;

                        if (arr[index] <= 0)
                        {
                            arr.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add") 
                {
                    if (index >= 0 && index < arr.Count)
                    {
                        arr.Insert(index, value);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike") 
                {
                    if (index > 0 && index < arr.Count && (index - value >= 0 || index + value < arr.Count))
                    {                       
                            arr.RemoveRange(index - value, (value * 2) + 1);                     
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                tokens = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join("|",arr));
        }
    }
}
