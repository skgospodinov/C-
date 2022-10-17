using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Validator
    {
        public static void ThrowIfNumberIsNotInRange(int min, int max, int value, string exeptionMessage) 
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(exeptionMessage);
            }

        }
        public static void ThrowIfValueIsNotAllowed(HashSet<string> allowedValues, string value, string exeptionMessage) 
        {
            if (!allowedValues.Contains(value))
            {
                throw new ArgumentException(exeptionMessage);

            }
        }
    }
}
