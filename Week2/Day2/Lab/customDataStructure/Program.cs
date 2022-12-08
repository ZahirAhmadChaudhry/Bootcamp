using System;
namespace customDataStructure
{
    internal class Program
    {
        public class StackQueue
        {
            // Create a stack and queue to store data
            Stack<int> stack;
            Queue<int> queue;

            // Constructor to initialize stack and queue
            public StackQueue()
            {
                stack = new Stack<int>();
                queue = new Queue<int>();
            }

            // Method to add elements to the stack
            public void Push(int data)
            {
                stack.Push(data);
            }

            // Method to add elements to the queue
            public void Enqueue(int data)
            {
                queue.Enqueue(data);
            }

            // Method to remove elements from the top of the stack
            public int Pop()
            {
                return stack.Pop();
            }

            // Method to remove elements from the front of the queue
            public int Dequeue()
            {
                return queue.Dequeue();
            }

            // Method to check if stack is empty
            public bool IsStackEmpty()
            {
                return stack.Count == 0;
            }

            // Method to check if queue is empty
            public bool IsQueueEmpty()
            {
                return queue.Count == 0;
            }
        }
        public static void Main(string[] args)
        {
            StackQueue stackQueue= new StackQueue();

            stackQueue.Push(1);
            stackQueue.Push(2);
            stackQueue.Push(3);
            Console.WriteLine(stackQueue.top());
            stackQueue.Pop();
        }
    }
}