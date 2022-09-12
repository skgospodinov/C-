using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Date_Modifier
{
    public static class DateModifier
    {
        public static int GetDiffBetweenTwoDates(string firstString, string secondString) 
        {
            DateTime firstDate=DateTime.Parse(firstString);
            DateTime secondDate=DateTime.Parse(secondString);

            TimeSpan diff = firstDate - secondDate;

            return Math.Abs(diff.Days);           
        }
    }
}
