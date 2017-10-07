using System;
using System.Linq;

namespace codeWars_CSharp.Models
{
    // This class provides several methods which will find the repeated int in an array whose count is odd. The promise is that the array will only ever have a single element whose count is odd.
    class OddCount
    {
        public static int Find(int[] integers) 
        {
            int OddNum = 0;
            
            // Get the count of each element in the array and grab the value of the array with an odd length
            foreach (int number in integers)
            {
                int[] NumArray = Array.FindAll(integers, x => x == number);
                
                if (NumArray.Length % 2 != 0)
                {
                    OddNum = NumArray[0];
                }
            }
            return OddNum;
        }

        public static int FindWithLinq(int[] integers)
        {
            // Group each int into IEnumerable and then find the one whose count is Odd
            return integers.GroupBy(x => x).Single(y => y.Count() % 2 != 0).Key; 
        }
    }
}