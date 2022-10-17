using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double coast;

        public Product(string name, double coast)
        {
            this.Name = name;
            this.Coast = coast;
        }

        public string Name 
        { 
            get => this.name;
            private set 
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name can not be empty");
                this.name = value;
            }
        }
        public double Coast 
        {
            get => this.coast;
            private set 
            {
                Validator.ThrowIfMoneIsNegative(value, "Money can not be negative");
                this.coast = value;
            } 
        }
    }
}
