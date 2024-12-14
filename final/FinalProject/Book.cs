using System.Security.Principal;

class Book 
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public bool Availability { get; set; }
    public int BookID { get; set; }

    public Book(string title, string author, string genre, bool availability, int identity)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Availability = availability;
        BookID = identity;
    }
    
}