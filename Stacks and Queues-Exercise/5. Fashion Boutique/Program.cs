using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothesToArrange = new Stack<int>(clothes);
            int sum = 0;
            int racks = 0;

            while (clothesToArrange.Count > 0)
            {
                int currentClothes = clothesToArrange.Pop();
                sum += currentClothes;
                if (sum == capacity && clothesToArrange.Count > 0)
                {
                    racks++;
                    sum = 0;
                }
                else if(sum > capacity)
                {
                    racks++;
                    sum = currentClothes; 
                }
                if(clothesToArrange.Count == 0) 
                {
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
