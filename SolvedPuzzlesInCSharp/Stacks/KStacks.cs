using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp.Stacks
{
    public class KStacks
    {
        const int ARRAY_SIZE = 10;
        const int STACK_COUNT = 3;
        const int INITIALIZED_VALUE = -1;

        private int[] ActualArray = new int[ARRAY_SIZE];
        private int[] NextEntryPointer = new int[ARRAY_SIZE]; //store next entry in all stacks 
        private int[] TopIndicatorArray = new int[STACK_COUNT];

        private int freeSlotPointer = 0; // beginning index of freeSlotPointer list

        public static void MainMethod()
        {
            var kStacks = new KStacks();
            kStacks.InitializeValues();

            kStacks.Push(25, 2);
            kStacks.Push(19, 1);
            kStacks.Push(27, 2);
            kStacks.Push(7, 0);
            kStacks.Push(17, 1);
            kStacks.Push(6, 0);
            kStacks.Push(10, 1);
            kStacks.Push(3, 0);

            Console.WriteLine($"Popped element from stack 2 is {kStacks.Pop(2)}");
            Console.WriteLine($"Popped element from stack 1 is {  kStacks.Pop(1)}");
            Console.WriteLine($"Popped element from stack 0 is {  kStacks.Pop(0)}");
        }

        private void InitializeValues()
        {
            // initialize all stacks as empty
            for (int i = 0; i < STACK_COUNT; i++)
            {
                TopIndicatorArray[i] = INITIALIZED_VALUE;
            }

            // initialize next entry pointers
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                NextEntryPointer[i] = i + 1;
            }
            NextEntryPointer[ARRAY_SIZE - 1] = INITIALIZED_VALUE;//end of freeSlotPointer list
        }

        private bool IsArrayFull()
        {
            return (freeSlotPointer == -1);
        }

        private bool IsStackEmpty(int stackNumber)
        {
            return (TopIndicatorArray[stackNumber] == INITIALIZED_VALUE);
        }

        private void Push(int value, int stackNumber)
        {
            if (IsArrayFull())
            {
                Console.WriteLine("Stack Overflow");

            }

            int i = freeSlotPointer;
            freeSlotPointer = NextEntryPointer[i];

            NextEntryPointer[i] = TopIndicatorArray[stackNumber];
            TopIndicatorArray[stackNumber] = i;
            ActualArray[i] = value;
        }


        private int Pop(int stackNumber)
        {
            if (IsStackEmpty(stackNumber))
            {
                Console.WriteLine("Stack is Empty");
                return int.MaxValue; ;
            }

            int index = TopIndicatorArray[stackNumber];
            TopIndicatorArray[stackNumber] = NextEntryPointer[index];
            NextEntryPointer[index] = freeSlotPointer;
            freeSlotPointer = index;

            return ActualArray[index];
        }
    }
}
