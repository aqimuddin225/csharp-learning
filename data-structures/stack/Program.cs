using System;
using System.Collections.Generic;   

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Pop an element from the stack
        int poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");

        // Peek at the top element without removing it
        int topElement = stack.Peek();
        Console.WriteLine($"Top element: {topElement}");

        // Check if the stack is empty
        bool isEmpty = stack.Count == 0;
        Console.WriteLine($"Is stack empty? {isEmpty}");
    }
}