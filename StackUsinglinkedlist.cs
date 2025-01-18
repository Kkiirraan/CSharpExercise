using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Stack
{
    private Node top; 
    public Stack()
    {
        top = null;
    }
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top; 
        top = newNode;      
        Console.WriteLine($"Pushed {data} onto the stack.");
    }
    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow! No elements to pop.");
            return -1; 
        }
        int poppedData = top.Data;
        top = top.Next; 
        Console.WriteLine($"Popped {poppedData} from the stack.");
        return poppedData;
    }
    public void Display()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements:");
        Node current = top;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.Display(); // Display stack elements

        stack.Pop();     // Pop an element
        stack.Display(); // Display stack after pop

        stack.Pop();
        stack.Pop();
        stack.Pop();     // Attempt to pop from an empty stack
    }
}
