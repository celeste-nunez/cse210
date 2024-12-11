using System.Collections.Concurrent;

class Catalog 
{
    public List <Book> catalog = new List<Book>{};

    protected void GetBooks(string filename) 
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
        }
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            var bookData = line.Split('~');

            if (bookData.Length == 4)
            {
                string bookTitle = bookData[0].Trim();
                string bookAuthor = bookData[1].Trim();
                string bookGenre = bookData[2].Trim();
                string bookAvailability = bookData[3].Trim();

                Book newBook = new Book(bookTitle, bookAuthor, bookGenre, bookAvailability);
                catalog.Add(newBook);
            }
        }
    }

    protected void SearchBook(string searchQuery)
    {
        searchQuery = searchQuery.ToLower();

        var results = catalog.Where(b => b.Title.ToLower().Contains(searchQuery) || b.Author.ToLower().Contains(searchQuery) || b.Genre.ToLower().Contains(searchQuery)).ToList();

        if (results.Count > 0)
        {
            foreach (var book in results)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.Availability}");
            }
        }
        else
        {
            Console.WriteLine($"No results found for {searchQuery}");
        }
    }
}