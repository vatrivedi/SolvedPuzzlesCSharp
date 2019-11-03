using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{
    class PartitionLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        // A utility function to create a new node  
        static Node newNode(int data)
        {
            Node new_node = new Node();
            new_node.data = data;
            new_node.next = null;
            return new_node;
        }

        /// <summary>
        /// Given a linked list and a value x, partition it such that all nodes less than x come first, 
        /// then all nodes with value equal to x and finally nodes with value greater than or equal to x. 
        /// </summary>
        public static void MainMethod()
        {
            Node head = newNode(10);
            head.next = newNode(4);
            head.next.next = newNode(5);
            head.next.next.next = newNode(30);
            head.next.next.next.next = newNode(2);
            head.next.next.next.next.next = newNode(50);

            int x = 3;
            head = partition(head, x);
            printList(head);
        }

        static Node partition(Node node, int x)
        {
            Node head = node;
            Node tail = node;
            Node current = null;

            while (node != null)
            {
                current = node.next;
                if (node.data < x)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                node = node.next;
            }
            tail.next = null;

            return head;
        }
        static void printList(Node head)
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
