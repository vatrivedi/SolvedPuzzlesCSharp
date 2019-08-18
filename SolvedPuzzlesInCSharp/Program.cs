using MyPuzzles.ArraysAndStrings;
using System;

namespace MyPuzzles
{
    class Program
    {

        static void Main(string[] args)
        {
            var condition = true;
            //just keeping the current solving problem in if condition; nothing else
            if (condition)
            {
                StringCompression.CompressedString("aabcccccaaa");
            }
            else
            {
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
