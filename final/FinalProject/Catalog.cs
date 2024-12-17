using System.Collections.Concurrent;

class Catalog 
{
    public List <Book> catalog = new List<Book>{};
    BorrowService _borrowService;

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

}




