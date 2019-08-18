using System;
using System.Collections.Generic;
using System.Text;

namespace MyPuzzles.ArraysAndStrings
{
    /// <summary>
    /// Implement an algo to determine if a string has all unique characters
    /// </summary>
    public class UniqueString
    {
        /// <summary>
        /// assume that we have a 256 ASCII char set
        /// </summary>
        /// <param name="source"></param>
        public static void VerifyUniqueStringAsciiSet(string source)
        {
            int tmp = 0;
            string result = "String has unique characters...";
            int[] asciiArray = new int[Constants.AsciiCharSet];
            // all are default to 0

            for (int i = 0; i < source.Length; i++)
            {
                tmp = (int)source[i] - 1;
                asciiArray[tmp]++;

                if (asciiArray[tmp] > 1)
                {
                    //result = "String does not have unique characters and Duplicate string is: " + tmp.ToString();
                    result = string.Empty;
                    result = String.Concat(result, "String does not have unique characters and Duplicate string is: ", source[i].ToString());
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
