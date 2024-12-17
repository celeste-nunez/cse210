using System.Collections.Concurrent;

class Catalog 
{
    public List <Book> catalog = new List<Book>{};

    public List<Book> GetBooks(string filename) 
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return catalog;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return catalog;
        }
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            var bookData = line.Split('~');

            if (bookData.Length >= 5)
            {
                string bookTitle = bookData[0].Trim();
                string bookAuthor = bookData[1].Trim();
                string bookGenre = bookData[2].Trim();
                bool bookAvailability = bool.Parse(bookData[3].Trim());
                int bookID = int.Parse(bookData[4].Trim());

                Book newBook = new Book(bookTitle, bookAuthor, bookGenre, bookAvailability, bookID);
                catalog.Add(newBook);
            }
        }
        return catalog;
    }  

    public List<Book> CreateNewBook()
    {
        Console.Write("Insert title: ");
        string title = Console.ReadLine();
        Console.Write("Insert author" );
        string author = Console.ReadLine();
        Console.Write("Insert Genre");
        string genre = Console.ReadLine();
        Console.Write("Insert Book ID: ");
        bool availability = true;
        int bookID = int.Parse(Console.ReadLine());

        Book newBook = new Book(title, author, genre, availability, bookID);
        catalog.Add(newBook);

        Console.WriteLine($"Book '{title}' has been added to the catalog.");
        return catalog;
    }

    public void DeleteExistingBook()
    {
        GetBooks("BooksList.txt");
        
        Console.WriteLine("Current books in catalog: ");
        foreach (var book in catalog)
        {
            Console.WriteLine($"ID: {book.BookID}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.Availability} ");
        }
        Console.Write("Enter the ID of the book you want to delete: ");
        int bookIDToDelete;
        if (int.TryParse(Console.ReadLine(), out bookIDToDelete))
        {
            var bookToRemove = catalog.FirstOrDefault(b => b.BookID == bookIDToDelete);

            catalog.Remove(bookToRemove);
            Console.WriteLine($"\nBook '{bookToRemove.Title}' has been removed from the catalog.");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter a valid book ID.");
        }
        
    }
}




