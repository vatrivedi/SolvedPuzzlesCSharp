using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    public class PalindromePermutation
    {
        /// <summary>
        /// Check if characters of a given string can be rearranged to form a palindrome
        /// ignore all characters apart from lower case - from 97 to 122 (ASCII Char Set)
        /// </summary>
        /// <param name="source">Sample string: Mr. owl ate my Metal worm</param>
        public static bool IsPalindromePermutation(string source)
        {
            int[] engArray = new int[26];
            short oddCharCount = 0;
            short tmp = 0;


            for (int i = 0; i < source.Length; i++)
            {
                tmp = (short)source[i];
                //ignore any thing other than between 97 and 122 - a to z
                if (tmp >= 97 && tmp <= 122)
                {
                    engArray[tmp - 97]++;
                }
            }

            //traverse through the array to verify if there are any odd repetitions of any character
            //if yes, then the total character count should not be > 1 for a palindrome

            for (int i = 0; i < engArray.Length; i++)
            {
                if (engArray[i] % 2 != 0)
                {
                    oddCharCount++;
                    if (oddCharCount > 1)
                    {
                        Console.WriteLine("String permutation is not a palindrome");
                        return false;
                    }
                }
            }

            Console.WriteLine("String permutation is a palindrome");
            return true;

        }
    }
}
