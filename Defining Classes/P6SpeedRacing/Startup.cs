using System;
using System.Collections.Generic;

namespace P6SpeedRacing
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {               
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(currentCar);
                input = Console.ReadLine().Split();
            }

            while (input[0]!= "End")
            {
                string carModel = input[1];
                int amountOfKm = int.Parse(input[2]);
                foreach (var item in cars)
                {
                    if (item.Model == carModel)
                    {
                        if (!item.Drive(amountOfKm))
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }                       
                    }
                }
               
                input = Console.ReadLine().Split();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}
