class Librarian : User
{
    // LibrarianMenu();
    public override void GetUserSelections()
    {
        LibrarianMenu();
        int userSelection = int.Parse(Console.ReadLine());
        
    }
}