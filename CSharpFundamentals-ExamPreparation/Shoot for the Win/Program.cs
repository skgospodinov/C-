using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            int shootIndex = 0;
            int count = 0;

            while (input?.ToUpper() != "END")
            {
                shootIndex = int.Parse(input);
                if (shootIndex >= 0 && shootIndex < sequence.Length && shootIndex != -1)
                {
                    count++;
                    int value = sequence[shootIndex];
                    sequence[shootIndex] = -1;

                    for (int i = 0; i < sequence.Length; i++)
                    {
                        if (sequence[i] != -1)
                        {
                            if (sequence[i] > value)
                            {
                                sequence[i] = sequence[i] - value;
                            }
                            else if (sequence[i] <= value)
                            {
                                sequence[i] = sequence[i] + value;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', sequence)}");
        }


    }
}
