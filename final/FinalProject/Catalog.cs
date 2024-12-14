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
                string bookAvailability = bookData[3].Trim();
                int bookID = int.Parse(bookData[4].Trim());

                Book newBook = new Book(bookTitle, bookAuthor, bookGenre, bookAvailability, bookID);
                catalog.Add(newBook);
            }
        }
        return catalog;
    }


    protected void SearchBook(string searchQuery)
    {   
        searchQuery = searchQuery.ToLower();

        var searchResults = catalog.Where(b => b.Title.ToLower().Contains(searchQuery) || b.Author.ToLower().Contains(searchQuery) || b.Genre.ToLower().Contains(searchQuery)).ToList();

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

    public void BorrowBook()
    {
        Console.WriteLine("Let's borrow a book!\n");
        Console.Write("To begin, please input a title, author, or genre to proceed: ");
        string _searchQuery =  Console.ReadLine();
        Console.WriteLine("\n");
        SearchBook(_searchQuery);
        Console.Write("\nNow input the ID of the book you'd like to checkout: ");
        int selectedID = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        var selectedBook = catalog.FirstOrDefault(b => b.BookID == selectedID);
        if (selectedBook != null)
        {
            if (selectedBook.Availability == "True")
            {
                selectedBook.Availability = "False";
                Console.WriteLine($"You have successfully checked out '{selectedBook.Title}'. Enjoy your read!");
                UpdateBookFile("BooksList.txt");
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

    private void UpdateBookFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var book in catalog)
                {
                    string line = $"{book.Title}~{book.Author}~{book.Genre}~{book.Availability}~{book.BookID}";
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("The file has been successfully updated.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while updating the file: {ex.Message}");
        }
    }

}




