using System;
using System.Collections.Generic;
using System.Text;

namespace MyPuzzles.ArraysAndStrings
{
    /// <summary>
    /// Check if two strings are permutation of each other - 
    /// A Permutation of a string is another string that contains same characters, 
    /// only the order of characters can be different. 
    /// For example, “abcd” and “dabc” are Permutation of each other.
    /// </summary>
    public static class IsStringPermutation
    {
        /// <summary>
        /// Check if two strings are permutation of each other - 
        /// A Permutation of a string is another string that contains same characters, 
        /// only the order of characters can be different. 
        /// For example, “abcd” and “dabc” are Permutation of each other.
        /// </summary>
        /// <param name="s1">First String</param>
        /// <param name="s2">Second String</param>
        /// <returns></returns>
        public static bool VerifyStringPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("String lengths are not equal; can't be permutation of each other");
                return false;
            }

            //first assume it is a 256-character ASCII set
            int tmp = 0;
            int[] charArray = new int[Constants.AsciiCharSet];

            //iterate through string-1 and increment the count 
            for (int i = 0; i < s1.Length; i++)
            {
                tmp = Convert.ToInt32(s1[i]);
                charArray[tmp]++;
            }

            //iterate through string-2 and decrement the count 
            for (int i = 0; i < s2.Length; i++)
            {
                tmp = Convert.ToInt32(s2[i]);
                charArray[tmp]--;
            }

            //now iterate through the array and check if all the values are zero, if not then break;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != 0)
                {
                    Console.WriteLine("Strings are NOT permutation of each other");
                    return false;
                }
            }

            Console.WriteLine("Strings are permutation of each other");
            return true;
        }
    }
}
