using System;
using System.Collections.Generic;

namespace codeWars_CSharp.Models
{
    public class OddManOut
    {
        // This method accepts a int[] full of either evens or odds and one int that is different from the others. The method retuns the int that is different from its group.
        public static int Find(int[] integers)
        {
            // Make Odd and Even arrays
            List<int> Odds = new List<int>();
            List<int> Evens = new List<int>();
            
            // Declare variable "n"
            var n = 0;
            
            // Loop through int array
            foreach (int number in integers)
            {
            if (number % 2 == 0)
            {
                Evens.Add(number);
            }
            else
            {
                Odds.Add(number);
            }      
            }
            
            // Find the array with the single element and assign its value to n
            if (Evens.Count == 1)
            {
            var evensArray = Evens.ToArray();
            n = evensArray[0];
            }
            else
            {
            var oddsArray = Odds.ToArray();
            n = oddsArray[0];
            }
            
            return n;
        }
    }
}