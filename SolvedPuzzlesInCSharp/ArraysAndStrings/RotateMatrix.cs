using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    public class RotateMatrix
    {
        /// <summary>
        /// this has O(n2) time complexity and O(1) space complexity
        /// </summary>
        /// <param name="matrix"></param>
        public static void RotateMatrixBy90Degress(int[][] matrix)
        {
            int matrixLen = matrix.Length;

            // An N x N matrix will have floor(N/2) square cycles
            // For e.g. - Both 4×4 & 5×5 will have 2 rotatable layers

            for (int layer = 0; layer < matrixLen / 2; layer++)
            {
                int first = layer;
                int last = matrixLen - first - 1;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int lastMinusOffset = last - offset;
                    // store variable in a temporary variable
                    int top = matrix[first][i];

                    // (top,left) points to (first,first) --> 0,0
                    // (top,right) points to (first,last) --> 0,n
                    // (bottom,left) points to (last,first) --> n,0
                    // (bottom,right) points to (last,last) --> n,n

                    // move values from left --> top
                    matrix[first][i] = matrix[lastMinusOffset][first];

                    // move values from bottom --> left
                    matrix[lastMinusOffset][first] = matrix[last][lastMinusOffset];

                    // move values from right --> bottom
                    matrix[last][lastMinusOffset] = matrix[i][last];

                    // move values from top  --> right

                    matrix[i][last] = top;
                }
            }
        }
    }
}
