//Task: Create a program that uses a Stack<T> to manage a stack of books.

//1. Create a Stack<string> to store book titles.

//2. Add five different book titles to the Stack<string>.

//3. Display all book titles in the stack.

//4. Pop the top book from the stack and display it.

//5. Peek at the top book in the stack without popping it.

//6. Display the total count of books in the stack.


namespace WorkingWithStack
{
    class Program
    {
        static void Main()
        {
            // Step 1: Create a Stack<string> to store book titles
            Stack<string> bookStack = new Stack<string>();

            // Step 2: Add five different book titles to the Stack<string>
            bookStack.Push("Book 1: The Great Gatsby");
            bookStack.Push("Book 2: To Kill a Mockingbird");
            bookStack.Push("Book 3: 1984");
            bookStack.Push("Book 4: The Catcher in the Rye");
            bookStack.Push("Book 5: Moby-Dick");

            // Step 3: Display all book titles in the stack
            Console.WriteLine("All books in the stack:");
            foreach (string book in bookStack)
            {
                Console.WriteLine(book);
            }

            // Step 4: Pop the top book from the stack and display it
            string poppedBook = bookStack.Pop();
            Console.WriteLine("\nPopped book: " + poppedBook);

            // Step 5: Peek at the top book in the stack without popping it
            string topBook = bookStack.Peek();
            Console.WriteLine("Top book in the stack: " + topBook);

            // Step 6: Display the total count of books in the stack
            int bookCount = bookStack.Count;
            Console.WriteLine("Total books remaining in the stack: " + bookCount);

            Console.WriteLine("\n Updated books in the stack:");
            foreach (string book in bookStack)
            {
                Console.WriteLine(book);
            }
        }
    }
}