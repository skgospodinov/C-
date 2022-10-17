using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                people = ReadPeople();
                products = ReadProduct();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputData = input.Split();
                string personName = inputData[0];
                string productName = inputData[1];

                Person person = people[personName];
                Product product = products[productName];
                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }

        private static Dictionary<string, Product> ReadProduct()
        {
            Dictionary<string, Product> result = new Dictionary<string, Product>();

            string[] parts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                string[] productsList = parts[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = productsList[0];
                double cost = double.Parse(productsList[1]);

                result[productName] = new Product(productName, cost);
            }
            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            Dictionary<string, Person> result = new Dictionary<string, Person>();

            string[] allPerson = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < allPerson.Length; i++)
            {
                string[] persons = allPerson[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string personName = persons[0];
                double money = double.Parse(persons[1]);
                result[personName] = new Person(personName, money);
            }
            return result;
        }
    }
}
