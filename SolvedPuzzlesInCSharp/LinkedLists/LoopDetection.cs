using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{
    public class LoopDetection
    {
        public Node head = null;
        public class Node
        {
            public int Value = 0;
            public Node Next = null;
            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }
        /// <summary>
        /// Given a circular linked list, implement an algorithm that retuns node at the beginning of the loop
        /// </summary>
        public static void MainMethod()
        {
            var linkedlist = new LoopDetection();

            linkedlist.AddNode(20);
            linkedlist.AddNode(4);
            linkedlist.AddNode(15);
            linkedlist.AddNode(10);
            linkedlist.AddNode(41);

            linkedlist.head.Next.Next.Next.Next = linkedlist.head;
            linkedlist.DetectLoop();
        }
        private void AddNode(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }

        private bool DetectLoop()
        {
            //first check if there is a loop!
            Node fastPointer = head;
            Node slowPointer = head;

            while (slowPointer != null && fastPointer != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;

                if (slowPointer == fastPointer)
                {
                    break;
                }
            }

            if (fastPointer == null || fastPointer.Next == null)
            {
                // no meeting point
                Console.WriteLine("No loop found");
                return false;
            }

            //move slow to head, keep fastPointer AS-IS...
            //move both the pointers with the same speed, wherever they meet is the circular loop node!
            slowPointer = head;
            while (slowPointer != fastPointer)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next;
            }

            Console.WriteLine($"Circular Node found: {fastPointer.Value}");
            return true;
        }
    }
}
