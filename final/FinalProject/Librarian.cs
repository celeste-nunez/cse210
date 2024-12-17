class Librarian : User
{
    // private BorrowService _borrowService;
    private Catalog _catalog;

    public Librarian(string userID, Catalog catalog) : base(userID, catalog)
    {
        _catalog = catalog;
    }

    public override void GetUserSelections()
    {
        while (true)
        {
            LibrarianMenu();
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (userSelection == 1)
            {
               _borrowService.BorrowBook(UserID);
            }
            if (userSelection == 2)
            {
                _borrowService.ReturnBook(UserID);
            }
            if (userSelection == 3)
            {
                _borrowService.GetPersonalHistory(UserID);
            }
            if (userSelection == 4)
            {
                _borrowService.GetAnotherUsersHistory();
            }
            if (userSelection == 5)
            {
                // cret4e new book
                _catalog.CreateNewBook();
            }
            if (userSelection == 6)
            {
                // remove a book
            }
            if (userSelection == 7)
            {
                break;
            }
        }
    }
}