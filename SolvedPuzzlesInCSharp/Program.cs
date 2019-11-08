using SolvedPuzzlesInCSharp.ArraysAndStrings;
using SolvedPuzzlesInCSharp.LinkedLists;
using SolvedPuzzlesInCSharp.Stacks;
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
                KStacks.MainMethod();
            }
            else
            {
                #region LinkedLists
                LinkIntersection.MainMethod();
                SumList.MainMethod();
                RemoveDups<int>.MainMethod();
                ReturnKthToLast.MainMethod(1);
                DeleteMiddleNode.MainMethod();
                LoopDetection.MainMethod();
                #endregion

                #region Array and Strings
                StringRotation.IsStringRotation("waterbottle", "erbottlewat");
                ZeroMatrixImplementation();
                RotateMatrixImplementation(4);
                StringCompression.CompressedString("aabcccccaaa");
                OneAway.IsStringOneAway("pale", "paled");
                PalindromePermutation.IsPalindromePermutation("Mr. owl ate my Metal worm");
                URLify.URLifyString("Spaces in this string will be replaced by percent20");
                IsStringPermutation.VerifyStringPermutation("abdcdefgh", "aefgb2cdh");
                UniqueString.VerifyUniqueStringAsciiSet("!@#$%$^&*()EFgh");
                HashTableImplentation();
                SwapWithoutTemp.SwapWithoutTempVar(12, 24);
                #endregion
            }
        }



        #region Methods for calling corresponding Problem-Classes 


        /// <summary>
        /// Initial method - Write an algo such that if an element in an MxN matrix is 0, its entire row and column are set to 0
        /// </summary>
        private static void ZeroMatrixImplementation()
        {
            int[][] matrix = new int[][]{
                new int[]{ 0, 1, 2, 0, 4, 5 },
                new int[]{ 1, 1, 2, 3, 4, 5 },
                new int[]{ 1, 1, 2, 3, 4, 5 },
                new int[]{ 1, 1, 2, 3, 4, 5 },
                new int[]{ 1, 1, 2, 3, 4, 0 }
            };
            Console.WriteLine($"row = " + matrix.Length + " column = " + matrix[0].Length);

            //ZeroMatrix.ZeroMatrixResult(matrix);
            ZeroMatrix.ZeroMatrixResultBitVector(matrix);

            Console.WriteLine("After setZero:");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.WriteLine(matrix[i][j] + " ");
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Given a N*N matrix , write a method to rotate the image by 90 degrees
        /// </summary>
        /// <param name="len"></param>
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
