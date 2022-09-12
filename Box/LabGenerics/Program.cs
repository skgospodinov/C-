using System;
using System.Collections.Generic;

namespace LabGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> stringList = new GenericList<string>();
            GenericList<List<string>> list = new GenericList<List<string>>();
            list.Add(new List<string>());
            PrintElement(5);
            PrintElement("string");
        }

        static void PrintElement<T>(T element) 
        {
            Console.WriteLine(element);
        }
    }
}
