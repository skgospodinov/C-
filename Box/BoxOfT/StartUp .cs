using System;

namespace BoxOfT
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxOfT<int> box = new BoxOfT<int>();
            box.Add(19);
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(2);
            Console.WriteLine(box.Count);
        }
    }
}
