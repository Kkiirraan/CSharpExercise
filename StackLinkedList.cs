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

    // Push: Insert an element into the stack
    public void Push(int data)
    {
        Node newNode = new Node(data);
        if (top == null)
        {
            top = newNode;
        }
        else
        {
            newNode.Next = top;
            top = newNode;
        }
        Console.WriteLine($"{data} pushed onto the stack.");
    }

    // Pop: Remove the top element from the stack
    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty! Cannot pop.");
            return;
        }

        int poppedValue = top.Data;
        top = top.Next;
        Console.WriteLine($"{poppedValue} popped from the stack.");
    }

    // Display: Show all elements in the stack
    public void Display()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty!");
            return;
        }

        Console.WriteLine("Stack elements are:");
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
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the value to push: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    stack.Push(value);
                    break;

                case 2:
                    stack.Pop();
                    break;

                case 3:
                    stack.Display();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
