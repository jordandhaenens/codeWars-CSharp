using System;
using System.Collections.Generic;

namespace codeWars_CSharp.Models
{
    public class Divide
    {
        // This method returns all divisors of the input number except 1 and the number. If number is prime it returns "null"
        //CodeWars server is saying that the method is too slow. I'll check back tomorrow and see if its the method or the servers
        public static int[] Divisors(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            int[] numbers = divisors.ToArray();
            if (numbers.GetLength(0) != 0)
            {
                return numbers;
            }
            else
            {
                return null;
            }
        }
    }
}