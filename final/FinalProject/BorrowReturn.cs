class BorrowService
{
    private Transactions _transactions = new Transactions();

    private Catalog _catalog;
    public BorrowService(Catalog catalog)
    {
        _catalog = catalog; 
    }

    private const string BookFileName = "BooksList.txt";
    private const string TransactionFileName = "Transactions.txt";

    public void BorrowBook(string IDCode)
    {
        Console.WriteLine("Let's borrow a book!\n");
        Console.Write("To begin, please input a title, author, or genre to proceed: ");
        string _searchQuery =  Console.ReadLine();
        Console.WriteLine("\n");
        SearchBook(_searchQuery);
        Console.Write("\nNow input the ID of the book you'd like to checkout: ");
        int selectedID = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        var selectedBook = _catalog.catalog.FirstOrDefault(b => b.BookID == selectedID);
        if (selectedBook != null)
        {
            if (selectedBook.Availability == true)
            {
                selectedBook.Availability = false;
                Console.WriteLine($"You have successfully checked out '{selectedBook.Title}'. Enjoy your read!\n");
                UpdateBookFile(BookFileName);
                _transactions.recordEvent(TransactionFileName, IDCode, "Borrow", selectedBook.Title, selectedBook.Author, selectedBook.Genre, selectedBook.Availability, selectedBook.BookID);
            }
            else 
            {
                Console.WriteLine($"Sorry, the book '{selectedBook.Title}' is already checked out.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid ID. No book matches the entered ID: {selectedID}");
        }
    }

    public void ReturnBook(string IDCode)
    {
        Console.WriteLine("Thank you for returning your books!\n");
        Console.Write("To begin, please input a title, author, or genre to proceed: ");
        string _searchQuery =  Console.ReadLine();
        Console.WriteLine("\n");
        SearchBook(_searchQuery);
        Console.Write("\nPlease confirm the book you are returning by inputing the ID: ");
        int selectedID = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        var selectedBook = _catalog.catalog.FirstOrDefault(b => b.BookID == selectedID);
        if (selectedBook != null)
        {
            if (selectedBook.Availability == false)
            {
                selectedBook.Availability = true;
                Console.WriteLine($"You have successfully returned '{selectedBook.Title}'. ");
                UpdateBookFile(BookFileName);
                _transactions.recordEvent(TransactionFileName, IDCode, "Return", selectedBook.Title, selectedBook.Author, selectedBook.Genre, selectedBook.Availability, selectedBook.BookID);
            }
            else 
            {
                Console.WriteLine($"Sorry, the book '{selectedBook.Title}' has already been returned.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid ID. No book matches the entered ID: {selectedID}");
        }
    }

    private void UpdateBookFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var book in _catalog.catalog)
                {
                    string line = $"{book.Title}~{book.Author}~{book.Genre}~{book.Availability}~{book.BookID}";
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while updating the file: {ex.Message}");
        }
    }

    public void SearchBook(string searchQuery)
    {   
        searchQuery = searchQuery.ToLower();

        var searchResults = _catalog.catalog.Where(b => b.Title.ToLower().Contains(searchQuery) || b.Author.ToLower().Contains(searchQuery) || b.Genre.ToLower().Contains(searchQuery)).ToList();

        if (searchResults.Count > 0)
        {
            foreach (var book in searchResults)
            {
                Console.WriteLine($"ID: {book.BookID}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.Availability}, ");
            }
        }
        else
        {
            Console.WriteLine($"No results found for {searchQuery}");
        }
    }
}