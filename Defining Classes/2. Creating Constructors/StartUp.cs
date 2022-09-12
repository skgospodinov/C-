using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person(22);
            Person person3 = new Person("Ivan", 30);

        }
    }
}
