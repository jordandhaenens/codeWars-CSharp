using System;
using System.Text.RegularExpressions;

namespace codeWars_CSharp.Models
{
    public class RemoveVowels
    {
        public string OutputString { get; set; }
        public RemoveVowels(string str)
        {
            string vowelPattern = "(?i)[aeiou]";
            Regex rgx1 = new Regex(vowelPattern);
            string replaceWithEmpty = "";
            string mString = rgx1.Replace(str, replaceWithEmpty);

            string whiteSpacePattern = "\\s+";
            string replaceWithWhiteSpace = " ";
            Regex rgx2 = new Regex(whiteSpacePattern);
            string manipulatedString = rgx2.Replace(mString, replaceWithWhiteSpace);

            OutputString = manipulatedString;
        }
    }
}