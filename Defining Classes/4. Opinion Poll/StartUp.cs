using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);
                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }
            List<Person> filteredPeople = people.Where(n => n.Age > 30).OrderBy(n => n.Name).ToList();
            foreach (var item in filteredPeople) 
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
            
        }
    }
}
