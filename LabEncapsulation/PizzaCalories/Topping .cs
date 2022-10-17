﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int MinValue = 1;
        private const int MaxValue = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name 
        {
            get => this.name;
            private set 
            {
                var valueAsLower = value.ToLower();
                
                Validator.ThrowIfValueIsNotAllowed(new HashSet<string> { "meat", "veggies", "cheese", "sauce" }, valueAsLower, $"Cannot place {value} on top of your pizza.");
                this.name = value;
            }
        }

        public int Weight 
        {
            get => this.weight;
            private set 
            {
                Validator.ThrowIfNumberIsNotInRange(MinValue, MaxValue, value, $"{this.Name} weight should be in the range [{MinValue}..{MaxValue}].");
                this.weight = value;
            }            
        }

        public double GetCalories() 
        {
            var modifier = GetModifier();
            return this.Weight * 2 * modifier;
        }

        private double GetModifier()
        {
            var nameToLower = this.Name.ToLower();
            if (nameToLower == "meat")
            {
                return 1.2;
            }
            else if (nameToLower == "veggies")
            {
                return 0.8;
            }
            else if (nameToLower == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }    

        }
    }
}
