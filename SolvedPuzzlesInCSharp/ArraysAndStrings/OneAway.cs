using System;
using System.Collections.Generic;
using System.Text;

namespace MyPuzzles.ArraysAndStrings
{
    public class OneAway
    {
        /// <summary>
        /// Given 2 strings, verify if they are 1 or 0 edits away
        /// </summary>
        /// <param name="s1">string 1</param>
        /// <param name="s2">string 2</param>
        /// <returns></returns>
        public static bool IsStringOneAway(string s1, string s2)
        {
            //we will consider lower-case English alphabets only
            int[] engArray = new int[26];
            var tmp = 0;
            var editCount = 0;

            //if string lengths differ by more than 1, then return
            if (Math.Abs(s1.Length - s2.Length) > 1)
            {
                Console.WriteLine("Length difference is more than 1, One Away edit doesn't exist");
                return false;
            }

            //append the english alphabet array from String 1
            for (int i = 0; i < s1.Length; i++)
            {
                tmp = (int)s1[i];
                engArray[tmp - 97]++;
            }

            //deduct the english alphabet arry from String 2
            for (int i = 0; i < s2.Length; i++)
            {
                tmp = (int)s2[i];
                engArray[tmp - 97]--;
            }

            //now check the count of edits; if count > 1, break
            for (int i = 0; i < engArray.Length; i++)
            {
                if (engArray[i] != 0)
                {
                    editCount++;
                    if (editCount > 2)
                    {
                        Console.WriteLine("One Away edit doesn't exist");
                        return false;
                    }
                }
            }

            Console.WriteLine("One Away edit exist");
            return true;

        }

    }
}
