using System;

namespace BackIn30Minutes
{
    class PBackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 > 59)
            {
                minutes = minutes + 30 - 60;
                hours += 1;
                if (hours > 23)
                {
                    hours -= 24;
                }
            }
            else
            {
                minutes += 30;
            }
            Console.WriteLine($"{hours}:{minutes:00}");
        }
    }
}