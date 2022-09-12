using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05SpecialCars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while (input != "No more tires")
            {
                string[] tireArr = input.Split();
                Tire[] currTires = new Tire[4]
                    {
                        new Tire(int.Parse(tireArr[0]), double.Parse(tireArr[1])),
                        new Tire(int.Parse(tireArr[2]), double.Parse(tireArr[3])),
                        new Tire(int.Parse(tireArr[4]), double.Parse(tireArr[5])),
                        new Tire(int.Parse(tireArr[6]), double.Parse(tireArr[7])),
                    };
                tires.Add(currTires);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                double[] engineArr = input.Split().Select(double.Parse).ToArray();

                int horsePower = (int)(engineArr[0]);
                double pressure = engineArr[1];
                Engine currEngine = new Engine(horsePower, pressure);
                engines.Add(currEngine);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Show special")
            {
                
                string[] currCars = input.Split();
                string name = currCars[0];
                string model = currCars[1];
                int year = int.Parse(currCars[2]);
                double fuelQuantity = double.Parse(currCars[3]);
                double fuelConsumption = double.Parse(currCars[4]);
                int engineIndex = int.Parse(currCars[5]);
                int tiresIndex = int.Parse(currCars[6]);
                Car currCar = new Car(name, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(currCar);
                input = Console.ReadLine();
            }
            string result = SpecialCars(cars);
            Console.WriteLine(result);

        }
        public static string SpecialCars(List<Car> cars) {
            List<Car> spcialCars = cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y=> y.Pressure) <= 10).ToList();
            StringBuilder result = new StringBuilder();
            foreach (var car in spcialCars) 
            {
                car.Drive(20);
                result.AppendLine($"Make:{car.Make}");
                result.AppendLine($"Model:{car.Model}");
                result.AppendLine($"Yesr:{car.Year}");
                result.AppendLine($"HorsePower:{car.Engine.HorsePower}");
                result.AppendLine($"FuelQuantity:{car.FuelQuantity}");
            }
            return result.ToString();
        }
    }
}
