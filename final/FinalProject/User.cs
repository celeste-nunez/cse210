using Microsoft.VisualBasic;

abstract class User
{
    protected void LibrarianMenu()
    {
        Console.WriteLine("1. Borrow book");
        Console.WriteLine("2. Return book");
        Console.WriteLine("3. View your borrowing history");
        Console.WriteLine("4. Update book details");
        Console.WriteLine("5. View transactions");
        Console.WriteLine("6. Add book to catalog");
        Console.WriteLine("7. Remove book from catalog");
        Console.WriteLine("8. Quit");
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