using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservations = new HashSet<string>();
            string input = Console.ReadLine();
            bool flag = false;
            while (input !="END")
            {
                if (input!= "PARTY" && input.Length == 8 && !flag)
                {
                    reservations.Add(input);
                }
                else if (input == "PARTY")
                {
                    flag = true;
                }
                if (flag)
                {
                    reservations.Remove(input);
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count);
            foreach (var item in reservations)
            {
                Console.WriteLine(item);
            }
        }
    }
}
