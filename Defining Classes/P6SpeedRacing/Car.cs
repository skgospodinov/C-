using System;
using System.Collections.Generic;
using System.Text;

namespace P6SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
               
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveled) 
        {
            double neededFuel = distanceTraveled * this.FuelConsumptionPerKilometer;
            if (neededFuel > this.FuelAmount)
            {
                return false;
            }
            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distanceTraveled;
            return true;
        }
    }
}
