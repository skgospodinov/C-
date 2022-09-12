using System;

namespace P02GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = GenericArrayCreator.Create(5, "kiki");
            Console.WriteLine(String.Join(",", array));
        }
    }
}
