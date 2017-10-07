using System;
using codeWars_CSharp.Models;

namespace codeWars_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // RemoveVowels Demo
            String String = "The day is so very fine. A hike would be nice.";
            RemoveVowels VowelShredder = new RemoveVowels(String);
            Console.WriteLine(VowelShredder.OutputString);


            // OddManOut Demo
            int[] integers = {12, 14, 46, 24, 23};
            int number = OddManOut.Find(integers);
            Console.WriteLine(number);


            // StringUnion Demo
            String S1 = "aretheyhere";
            String S2 = "yestheyarehere";
            var S3 = StringUnion.UnionOf(S1, S2);
            Console.WriteLine(S3);
        }
    }
}
