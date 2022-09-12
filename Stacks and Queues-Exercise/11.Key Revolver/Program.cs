using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int billetPrice = int.Parse(Console.ReadLine());
            int sizeOfBarel = int.Parse(Console.ReadLine());
            
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bulletsStack = new Stack<int>(bullets);

            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locksQueue = new Queue<int>(locks);

            int valueOfintelligence = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currentSizeOfBarel = sizeOfBarel;

            while(bulletsStack.Any() && locksQueue.Any())
            {
                
                bulletsCount++;
                currentSizeOfBarel--;
                int currBullet = bulletsStack.Pop();
                int currLock =  locksQueue.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentSizeOfBarel == 0 && bulletsStack.Any())
                {
                    currentSizeOfBarel = sizeOfBarel;
                    Console.WriteLine("Reloading!");
                }
            }

            if (!locksQueue.Any())
            {
                int moneyEarned = valueOfintelligence - (bulletsCount * billetPrice);
                Console.WriteLine( $"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
                
            }
            else 
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
