using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            
            Engine v12 = new Engine(580, 1200);
            Tire[] tires = new Tire[]
            {
                new Tire(2000,2.2),
                new Tire(2000,2.2),
                new Tire(2000,2.2),
                new Tire(2000,2.2)
            };
            Car bmw = new Car("BMW", "X6",1999, 5003, -50, v12,tires);
            Console.WriteLine("Horse power: " + bmw.Engine.HorsePower);

            foreach (var item in bmw.Tires)
            {
                Console.WriteLine($"{item.Year} - {item.Pressure}");
            }
        }
    }
}
