using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    class SwapWithoutTemp
    {
        /// <summary>
        /// Swap 2 variable without using a Temporary variable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapWithoutTempVar(int a, int b)
        {
            Console.WriteLine($"Initial values are a: {a} and b: {b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(($"Final values are a: {a} and b: {b}"));
        }
    }
}
