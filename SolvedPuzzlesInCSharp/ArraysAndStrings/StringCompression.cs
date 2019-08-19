using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    public class StringCompression
    {
        /// <summary>
        /// Implement a method to perform basic string compression using the counts of repeated characters. 
        /// For e.g. - the string aabcccccaaa would become a2b1c5a3.If the compressed stirng would not become small than the original string, your method should
        /// return the original string.
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns></returns>
        public static string CompressedString(string source)
        {
            int countConsecutive = 0;
            string compressed = String.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < source.Length; i++)
            {
                countConsecutive++;
                if (i >= source.Length - 1 || source[i] != source[i + 1])
                {
                    sb.Append(source[i]);
                    sb.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            compressed = sb.ToString();
            Console.WriteLine($"Compressed String is {compressed}");
            return (compressed.Length < source.Length) ? compressed : source;
        }
    }
}
