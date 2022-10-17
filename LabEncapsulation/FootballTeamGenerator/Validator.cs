using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Validator
    {
        public static void IfIsValidRange(int MinStats, int MaxStats, int value, string exeptionMessage) 
        {
            if (value < MinStats || value > MaxStats)
            {
                throw new ArgumentException(exeptionMessage);
            }
        }

        public static void ThrowIfStringIsNullOrWhiteSapce(string str, string exeptionMessage) 
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exeptionMessage);
            }
        }
    }
}
