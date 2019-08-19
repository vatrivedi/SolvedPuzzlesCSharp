using SolvedPuzzlesInCSharp.ArraysAndStrings;
using System;

namespace SolvedPuzzlesInCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            var condition = true;
            //just keeping the current solving problem in if condition; nothing else
            if (condition)
            {

                RotateMatrixImplementation(4);
            }
            else
            {

                StringCompression.CompressedString("aabcccccaaa");
                OneAway.IsStringOneAway("pale", "paled");
                PalindromePermutation.IsPalindromePermutation("Mr. owl ate my Metal worm");
                URLify.URLifyString("Spaces in this string will be replaced by percent20");
                IsStringPermutation.VerifyStringPermutation("abdcdefgh", "aefgb2cdh");
                UniqueString.VerifyUniqueStringAsciiSet("!@#$%$^&*()EFgh");
                HashTableImplentation();
                SwapWithoutTemp.SwapWithoutTempVar(12, 24);
            }
        }


        #region Methods for calling corresponding Problem-Classes 

        public static void RotateMatrixImplementation(int len)
        {
            int[][] matrix = new int[len][];
            var random = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[len]; // Create inner array
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    //generate random numbers
                    matrix[i][j] = random.Next(1, Convert.ToInt32(Math.Pow(len, 3)));
                }
            }
            RotateMatrix.RotateMatrixBy90Degress(matrix);
        }

        public static void HashTableImplentation()
        {
            var hashTableImpl = new HashTableImpl<string, string>(Constants.HashTableImplItemCount);
            hashTableImpl.Add("1", "ITEM 1");
            hashTableImpl.Add("2", "ITEM 2");
            hashTableImpl.Add("3", "ITEM 3");
            hashTableImpl.Add("4", "ITEM 4");

            hashTableImpl.Remove("4");
            hashTableImpl.Find("2");
        }

        #endregion
    }
}
