using static System.Reflection.Metadata.BlobBuilder;

namespace BookManagementSystem_Assesment1
{
    internal class Program
    {

        class Book
        {
            public int BookID { get; set; }
            public string BookName { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
            public string Publisher { get; set; }
            public int NumberOfPages { get; set; }
            public string Language { get; set; } = "English";
            public string LoT { get; set; } = "Technical";
            public string Summary { get; set; }

            public void EnterBookDetails()
            {
                Console.WriteLine("Enter Book ID (5 digits): ");
                BookID = ValidateBookID(Console.ReadLine());

                Console.WriteLine("Enter Book Name: ");
                BookName = ValidateBookName(Console.ReadLine());

                Console.WriteLine("Enter ISBN Number: ");
                ISBN = Console.ReadLine();

                Console.WriteLine("Enter Price: ");
                Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Publisher: ");
                Publisher = Console.ReadLine();

                Console.WriteLine("Enter Number of Pages: ");
                NumberOfPages = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Language (Optional, default is 'English'): ");
                string language = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(language))
                    Language = language;

                Console.WriteLine("Enter LoT (Optional, default is 'Technical'): ");
                string lot = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lot))
                    LoT = ValidateLoT(lot);

                Console.WriteLine("Enter Summary: ");
                Summary = Console.ReadLine();
            }

            int ValidateBookID(string input)
            {
                if (string.IsNullOrWhiteSpace(input) || input.Length != 5 || !int.TryParse(input, out int bookId))
                {
                    throw new ArgumentException("Invalid Book ID. It should be a 5 digit number.");
                }
                return bookId;
            }

            string ValidateBookName(string input) 
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("Book Name cannot be empty.");
                }
                    return input;
            }
            string ValidateLoT(string input)
            {
                string[] validLoTs = { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS" };
                if(Array.IndexOf(validLoTs, input) < 0)
                {
                    throw new ArgumentException("Invalid LoT. It should be one of the following: .NET, Java, IMS, V&V, BI, RDBMS.");
                }
                return input;
            }

        }
        static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("\nBook Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        DisplayBooks();
                        break;
                    case 3:
                        DeleteBook();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            try
            {
                Book book = new Book();
                book.EnterBookDetails();
                books.Add(book);
                Console.WriteLine("Book added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("\nBooks in Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookID}, Name: {book.BookName}, ISBN: {book.ISBN}, Price: {book.Price}, Publisher: {book.Publisher}, Pages: {book.NumberOfPages}, Language: {book.Language}, LoT: {book.LoT}, Summary: {book.Summary}");
            }
        }

        static void DeleteBook()
        {
            Console.WriteLine("Enter Book ID to delete: ");
            int bookID = int.Parse(Console.ReadLine());

            var book = books.Find(b => b.BookID == bookID);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}