using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    public class URLify
    {
        /// <summary>
        /// Write a method to replace all spaces in a string with "%20"
        /// </summary>
        /// <param name="source"></param>
        public static void URLifyString(string source)
        {
            string replaceSpace = "%20";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == Constants.SpaceIdentifier)
                {
                    sb.Append(replaceSpace);
                }
                else
                {
                    sb.Append(source[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
