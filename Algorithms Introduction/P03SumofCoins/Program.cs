using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SumofCoins
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> coins = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Dictionary<int, int> usedCoins = new Dictionary<int, int>();
            int targetSum = int.Parse(Console.ReadLine());
            int countCoins = 0;
            int currCount = 0;
            //50,20,10,5,2,1
            coins = coins.OrderByDescending(c => c).ToList();

            for (int i = 0; i < coins.Count; i++)
            {
                if (targetSum >= coins[i])
                {
                    currCount = targetSum / coins[i];
                    targetSum = targetSum - currCount * coins[i];
                    countCoins += currCount;
                    if (!usedCoins.ContainsKey(coins[i]))
                    {
                        usedCoins[coins[i]]=0;
                    }
                    usedCoins[coins[i]]=currCount;
                }
            }

            if (targetSum > 0)
            {
                throw new InvalidOperationException("Error");
            }

            try
            {
                Console.WriteLine($"Number of coins to take: {countCoins}");
                foreach (var (key, value) in usedCoins)
                {
                    Console.WriteLine($"{value} coin(s) with value {key}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }                     
        }
    }
}
