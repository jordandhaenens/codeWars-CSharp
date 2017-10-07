using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars_CSharp.Models
{
    public class StringUnion
    {
        // This method accepts two strings and returns the sorted union of the two 
        public static string UnionOf(string S1, string S2)
        {
            // Split strings into arrays
            Char[] Array1 = S1.ToArray();
            Char[] Array2 = S2.ToArray();

            // Get sorted union of the two arrays
            IEnumerable<char> Union = Array1.Union(Array2).OrderBy(element => element);
    
            // Build a return string
            String S3 = "";
            foreach (char item in Union)
            {
                S3 += item;
            }

            return S3;
        }

        // This is a way cooler method I didn't think of right away. It accomplishes the same thing as the above method
        public static string Longest (string s1, string s2) 
        {
                return new string ((s1 +s2).Distinct().OrderBy(x=>x).ToArray ());
        }
    }
}