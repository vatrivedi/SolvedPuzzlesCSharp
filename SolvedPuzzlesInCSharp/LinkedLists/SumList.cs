using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.LinkedLists
{
    class SumList
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
        public int listCount = 0;

        /// <summary>
        /// You have two numbers represented by a linked list, where each node contains a single digit. 
        /// The digits are stored in reverse order, such that the 1s digit is at the head of the list. 
        /// Write a function that adds the two numbers and returns the sum as a linked list.
        /// </summary>
        public static void MainMethod()
        {
            var sl1 = new SumList();
            sl1.AddNodeAtLast(7);
            sl1.AddNodeAtLast(1);
            sl1.AddNodeAtLast(6);

            var sl2 = new SumList();
            sl2.AddNodeAtLast(5);
            sl2.AddNodeAtLast(9);
            sl2.AddNodeAtLast(2);

            AddItemsInList(sl1, sl2);

            //TO-DO - return the result as a linked list -  this is pending!!!
        }

        private static void AddItemsInList(SumList firstList, SumList secondList)
        {
            var sl3 = new SumList();
            var power = 0;
            //sl3.
            int firstListSum = 0, secondListSum = 0;
            if (firstList.listCount == secondList.listCount)
            {
                var currentNode = firstList.head;
                while (currentNode != null)
                {
                    firstListSum += currentNode.Value * Convert.ToInt32(Math.Pow(10, power));
                    currentNode = currentNode.Next;
                    power++;
                    //firstListSum += firstList.;
                }

                currentNode = secondList.head;
                power = 0;
                while (currentNode != null)
                {
                    secondListSum += currentNode.Value * Convert.ToInt32(Math.Pow(10, power));
                    currentNode = currentNode.Next;
                    power++;
                }

                var resultOfLists = firstListSum + secondListSum;
                Console.WriteLine($"Sum of the list is {resultOfLists}");
            }
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
            listCount++;
        }
    }
}
