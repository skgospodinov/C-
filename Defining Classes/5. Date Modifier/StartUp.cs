using System;

namespace _5._Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            int result = DateModifier.GetDiffBetweenTwoDates(firstString, secondString);
            Console.WriteLine(result);
        }
    }
}
