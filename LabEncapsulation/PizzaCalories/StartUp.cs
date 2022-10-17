using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine().Split()[1];
            string[] doughtData = Console.ReadLine().Split();

            string flourType = doughtData[1];
            string bakingTechinique = doughtData[2];
            int weight = int.Parse(doughtData[3]);

            Dough dough = new Dough(flourType, bakingTechinique, weight);
            Pizza pizza = new Pizza(pizzaName, dough);

            try
            {
                string line = Console.ReadLine();
                while (line != "END")
                {
                    string[] parts = line.Split();

                    var toppingName = parts[1];
                    var toppingWeight = int.Parse(parts[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);

                    line = Console.ReadLine();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
            }
            catch (Exception e)
                    when (e is ArgumentException || e is InvalidOperationException)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
