using Microsoft.VisualBasic;

abstract class User
{
    public string UserID { get; private set; }
    protected BorrowService _borrowService;

    protected User(string userId, Catalog catalog)
    {
        UserID = userId;
        _borrowService = new BorrowService(catalog);
    }

    protected void LibrarianMenu()
    {
        Console.WriteLine("1. Borrow book");
        Console.WriteLine("2. Return book");
        Console.WriteLine("3. View your borrowing history");
        Console.WriteLine("4. Update book details");
        Console.WriteLine("5. View transactions");
        Console.WriteLine("6. Add book to catalog");
        Console.WriteLine("7. Remove book from catalog");
        Console.WriteLine("8. Quit\n");
        Console.Write("Please make a selection: ");
    }
    protected void MemberMenu()
    {
        Console.WriteLine("1. Borrow book");
        Console.WriteLine("2. Return book");
        Console.WriteLine("3. View your borrowing history");
        Console.WriteLine("4. Quit");
        Console.Write("Please make a selection: ");

    }

    // protected Catalog getLibraryCatalog()
    // {
    //     LibraryCatalog = new Catalog();
    //     LibraryCatalog.GetBooks("BooksList.txt");
    //     return LibraryCatalog;
    // }

    public abstract void GetUserSelections();


}