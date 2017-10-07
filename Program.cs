using System;
using codeWars_CSharp.Models;

namespace codeWars_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This method accepts a string and returns a string sans vowels
            string String = "The day is so very fine. A hike would be nice.";
            RemoveVowels VowelShredder = new RemoveVowels(String);
            Console.WriteLine(VowelShredder.OutputString);


            // This method accepts a int[] full of either evens or odds and one int that is different from the others. The method retuns the int that is different from its group.
            int[] integers = {12, 14, 46, 24, 23};
            int number = OddManOut.Find(integers);
            Console.WriteLine(number);
        }
    }
}
