using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    /// <summary>
    /// Assume you have a method iSubstring which checks if one word is substring of another. 
    /// Given 2 strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring 
    /// (e.g. waterbottle is a rotation of  erbottlewat)
    /// </summary>
    class StringRotation
    {
        /// <summary>
        /// Assume you have a method iSubstring which checks if one word is substring of another. 
        /// Given 2 strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring 
        /// (e.g. waterbottle is a rotation of  erbottlewat)
        /// </summary>
        /// <param name="s1">string 1</param>
        /// <param name="s2">string 2</param>
        public static void IsStringRotation(string s1, string s2)
        {
            // waterbottlewaterbottle
            if (s1.Length == s2.Length && (s1 + s1).IndexOf(s2) != -1)
            {
                Console.WriteLine($"{s2} is a rotation of {s1}");
            }
            else
            {
                Console.WriteLine($"{s2} is not a rotation of {s1}");
            }

        }
    }
}
