using System;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string[] car = Console.ReadLine().Split(", ");

            while (car[0] != "END")
            {
                string currCar = car[1];
                if (car[0] == "IN")
                {
                    cars.Add(currCar);
                }
                else if (car[0] == "OUT") 
                {
                    cars.Remove(currCar);
                }

                car = Console.ReadLine().Split(", ");
            }

            if (cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
