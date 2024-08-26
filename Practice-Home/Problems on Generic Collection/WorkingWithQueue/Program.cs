//Task: Create a program that uses a Queue<T> to manage a queue of tasks.

//1. Create a Queue<string> to store a list of tasks.

//2. Add five different tasks to the Queue<string>.

//3. Display all tasks in the queue.

//4. Dequeue the first task and display it.

//5. Peek at the next task in the queue without dequeuing it.

//6. Display the total count of tasks in the queue.

namespace WorkingWithQueue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Step 1: Create a Queue<string> to store a list of tasks
            Queue<string> taskQueue = new Queue<string>();

            // Step 2: Add five different tasks to the Queue<string>
            taskQueue.Enqueue("Task 1");
            taskQueue.Enqueue("Task 2");
            taskQueue.Enqueue("Task 3");
            taskQueue.Enqueue("Task 4");
            taskQueue.Enqueue("Task 5");

            // Step 3: Display all tasks in the queue
            Console.WriteLine("All tasks in the queue:");
            foreach (string task in taskQueue)
            {
                Console.WriteLine(task);
            }

            // Step 4: Dequeue the first task and display it
            string dequeuedTask = taskQueue.Dequeue();
            Console.WriteLine("\nDequeued task: " + dequeuedTask);

            // Step 5: Peek at the next task in the queue without dequeuing it
            string nextTask = taskQueue.Peek();
            Console.WriteLine("Next task in the queue: " + nextTask);

            // Step 6: Display the total count of tasks in the queue
            int taskCount = taskQueue.Count;
            Console.WriteLine("Total tasks remaining in the queue: " + taskCount);
        }
    }

}