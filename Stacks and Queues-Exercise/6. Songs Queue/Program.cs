using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            string command = Console.ReadLine();
            Queue<string> songsQueue = new Queue<string>(songs); 

            while (songsQueue.Count > 0) 
            {
                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string newSong = command.Substring(4);
                    if (songsQueue.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                    else 
                    {
                        songsQueue.Enqueue(newSong);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }                
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
