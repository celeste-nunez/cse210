class Book 
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Availability { get; set; }

    public Book(string title, string author, string genre, string availability)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Availability = availability;
    }
    
}