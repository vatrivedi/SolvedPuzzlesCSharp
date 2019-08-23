using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{
    class ReturnKthToLast
    {
        /// <summary>
        /// Find Kth to Last Element in a Singly Linked List
        /// </summary>
        /// <param name="k">Kth element to find</param>
        public static void MainMethod(int k)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(10);
            ll.AddLast(12);
            ll.AddLast(2);
            ll.AddLast(8);
            ll.AddLast(9);
            ll.AddLast(22);
            ll.AddLast(17);
            ll.AddLast(19);
            ll.AddLast(20);

            ReturnKthElement(ll, k);
        }

        private static bool ReturnKthElement(LinkedList<int> ll, int k)
        {
            LinkedListNode<int> p1 = ll.First;
            LinkedListNode<int> p2 = ll.First;


            for (int i = 0; i < k; i++)
            {
                p2 = p2.Next;
                if (p2 == null)
                {
                    Console.WriteLine($"Linkedlist is smaller than {k}th Element");
                    return false;
                }
            }

            while (p2 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            //p1 is the Kth Element
            Console.WriteLine($"Kth element is {p1.Value}");
            return true;
        }
    }
}
