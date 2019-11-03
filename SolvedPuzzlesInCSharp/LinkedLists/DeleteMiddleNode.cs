using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{

    class DeleteMiddleNode
    {
        public class Node
        {
            public Node Next;
            public int Value;

            public Node(int val)
            {
                this.Value = val;
                this.Next = null;
            }
        }
        private Node head = null;
        private Node current = null;
        public int count = 0;

        public static void MainMethod()
        {
            DeleteMiddleNode dm = new DeleteMiddleNode();
            dm.AddNodeAtStart(12);
            dm.AddNodeAtLast(9);
            dm.AddNodeAtLast(11);
            dm.AddNodeAtLast(6);
            dm.AddNodeAtLast(25);
            dm.AddNodeAtLast(14);

            dm.DeleteMiddleOne(dm, 9);
        }

        private void AddNodeAtLast(int v)
        {
            Node newNode = new Node(v);
            if (head == null)
            {
                head = newNode;
                head.Next = null;
                current = head;
            }
            else
            {
                current.Next = newNode;
                current = newNode;
            }
            count++;
        }

        private void AddNodeAtStart(int v)
        {
            Node newNode = new Node(v);
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        private void DeleteMiddleOne(DeleteMiddleNode dm, int val)
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine($"BEFORE DELETION - Elements in the linked-list are {curr.Value}");
                curr = curr.Next;
            }

            curr = head;
            while (curr != null)
            {
                //traverse to the middle value
                if (curr.Value == val)
                {
                    curr.Next = curr.Next.Next;
                }
                curr = curr.Next;
            }

            curr = head;
            while (curr != null)
            {
                Console.WriteLine($"AFTER DELETION - Elements in the linked-list are {curr.Value}");
                curr = curr.Next;
            }
        }
    }
}
