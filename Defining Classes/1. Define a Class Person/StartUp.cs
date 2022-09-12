using System;

namespace DefiningClasses
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Peter";
            peter.Age = 20;

            Person george = new Person()
            {
                Name = "George",
                Age = 22
            };

            Person jose = new Person("Jose", 43);
        }
    }
}
