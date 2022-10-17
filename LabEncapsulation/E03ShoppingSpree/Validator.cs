using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exeptionMessage) 
        {
            if (string.IsNullOrWhiteSpace(str)) 
            {
                throw new ArgumentException(exeptionMessage);
            }
        }

        public static void ThrowIfMoneIsNegative(double money, string exeptionMessage) 
        {
            if (money < 0)
            {
                throw new ArgumentException(exeptionMessage);
            }
        }
    }
}
