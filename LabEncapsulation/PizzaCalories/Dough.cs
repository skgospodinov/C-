using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private const string InvalidDoughExeptionMessage= "Invalid type of dough.";

        private string flaourType;
        private string backingTechique;
        private int weight;

        public Dough(string flaourType, string backingTechnique, int weight)
        {
            this.FlaourType = flaourType;
            this.BackingTechique = backingTechnique;
            this.Weight = weight;
        }

        public string FlaourType 
        {
            get => this.flaourType;
            private set 
            {
                var valueAsLower = value.ToLower();                
                Validator.ThrowIfValueIsNotAllowed(new HashSet<string> { "white", "wholegrain"}, valueAsLower, InvalidDoughExeptionMessage);
                this.flaourType = value;
            } 
        }
        public string BackingTechique 
        {
            get => backingTechique;
            private set 
            {
                var valueAsLower = value.ToLower();                
                Validator.ThrowIfValueIsNotAllowed(new HashSet<string> { "crispy", "chewy" , "homemade" }, valueAsLower, InvalidDoughExeptionMessage);
                this.backingTechique = value;
            } 
        }
        public int Weight
        {
            get => weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange
                    (MinWeight, MaxWeight, value, $"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                this.weight = value;
            }
        }

        public double GetCalories() 
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetBackingTechniqueModifier();
            return this.Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBackingTechniqueModifier()
        {
            var backingTechiqueToLower = this.BackingTechique.ToLower();
            if (backingTechiqueToLower == "crispy")
            {
                return 0.9;
            }
            else if (backingTechiqueToLower == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

        private double GetFlourTypeModifier()
        {
            var flourTypeAsLower = this.FlaourType.ToLower();
            if (flourTypeAsLower == "white")
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
        }
    }
}
