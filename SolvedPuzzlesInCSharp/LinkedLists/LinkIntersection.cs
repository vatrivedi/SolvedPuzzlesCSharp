using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{
    class LinkIntersection
    {
        const int NOT_FOUND = -1;

        public Node head1, head2;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int value)
            {
                this.data = value;
                next = null;
            }
        }
        /// <summary>
        /// Given two linked lists, determine if they intersect. Return the intersecting node. 
        /// </summary>
        public static void MainMethod()
        {
            var list = new LinkIntersection();

            // creating first linked list 
            list.head1 = new Node(3);
            list.head1.next = new Node(6);
            list.head1.next.next = new Node(9);
            list.head1.next.next.next = new Node(15);
            list.head1.next.next.next.next = new Node(30);

            // creating second linked list 
            list.head2 = new Node(10);
            list.head2.next = new Node(15);
            list.head2.next.next = new Node(30);

            Console.WriteLine("Intersection Node is: " + list.GetNode());
        }

        private string GetNode()
        {
            int countOfFirstList = GetListItemCount(head1);
            int countOfSecondList = GetListItemCount(head2);
            int difference = 0;

            if (countOfFirstList > countOfSecondList)
            {
                difference = countOfFirstList - countOfSecondList;
                GetIntersectionNode(difference, head1, head2);
            }
            else
            {
                difference = countOfSecondList - countOfFirstList;
                GetIntersectionNode(difference, head2, head1);
            }
            return null;

        }

        private int GetIntersectionNode(int difference, Node head1, Node head2)
        {
            // traverse difference so that both lists are equal
            Node current1 = head1;
            Node current2 = head2;

            while (current1 != null && difference > 0)
            {
                difference--;
                current1 = current1.next;
            }

            while (current1 != null && current2 != null)
            {
                if (current1.data == current2.data)
                {
                    return current1.data;
                }
                current1 = current1.next;
                current2 = current2.next;
            }
            return NOT_FOUND;
        }


        private int GetListItemCount(Node nodeHead)
        {
            int size = 0;
            Node current = nodeHead;
            while (current != null)
            {
                size++;
                current = current.next;
            }
            return size;
        }
    }
}
