using Microsoft.VisualBasic;

abstract class User
{
    public string UserID { get; private set; }
    protected BorrowService _borrowService;

    protected User(string userId, Catalog catalog)
    {
        UserID = userId;
        _borrowService = new BorrowService(catalog, new Transactions());
    }

    protected void LibrarianMenu()
    {
        Console.WriteLine("1. Borrow book");
        Console.WriteLine("2. Return book");
        Console.WriteLine("3. View your borrowing history");
        Console.WriteLine("4. View another user's transactions");
        Console.WriteLine("5. Add book to catalog");
        Console.WriteLine("6. Remove book from catalog");
        Console.WriteLine("7. Quit\n");
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

    public abstract void GetUserSelections();


}