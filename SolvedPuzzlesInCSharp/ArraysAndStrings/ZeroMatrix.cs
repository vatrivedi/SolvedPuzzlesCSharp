using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.ArraysAndStrings
{
    class ZeroMatrix
    {
        /// <summary>
        /// Write an algo such that if an element in an MxN matrix is 0, its entire row and column are set to 0
        /// </summary>
        /// <param name="matrix">MxN matrix</param>
        public static void ZeroMatrixResult(int[][] matrix)
        {
            bool[] rowArray = new bool[matrix.Length];
            bool[] colArray = new bool[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowArray[i] = true;
                        colArray[j] = true;
                    }
                }
            }

            //nullify all row related records
            for (int i = 0; i < matrix.Length; i++)
            {
                if (rowArray[i])
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            //nullify all column related records
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (colArray[j])
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        public static void ZeroMatrixResultBitVector(int[][] matrix)
        {
            bool rowZero = false;
            bool colZero = false;

            // check if first row has zero
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    colZero = true;
                    break;
                }
            }

            // check if first column is zero
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    rowZero = true;
                    break;
                }
            }

            //if the above hasn't been true then we will update the first column/row later
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            //nullify all row related records
            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    nullifyRow(matrix, i);
                }
            }

            //nullify all column related records
            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    nullifyColumn(matrix, j);
                }
            }

            if (rowZero)
            {
                nullifyRow(matrix, 0);
            }

            if (colZero)
            {
                nullifyColumn(matrix, 0);
            }

        }

        private static void nullifyRow(int[][] matrix, int row)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[row][j] = 0;
            }
        }

        private static void nullifyColumn(int[][] matrix, int column)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[i][column] = 0;
            }
        }

    }
}
