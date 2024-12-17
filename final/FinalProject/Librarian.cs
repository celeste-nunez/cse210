class Librarian : User
{
    // private BorrowService _borrowService;
    private Catalog _catalog;
    private Transactions _transactions;

    public Librarian(string userID, Catalog catalog, Transactions transactions) : base(userID, catalog)
    {
        _catalog = catalog;
        _transactions = transactions;
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
                _transactions.GetPersonalHistory(UserID);
            }
            if (userSelection == 4)
            {
                _transactions.GetAnotherUsersHistory();
            }
            if (userSelection == 5)
            {
                _catalog.CreateNewBook();
            }
            if (userSelection == 6)
            {
                _catalog.DeleteExistingBook();
            }
            if (userSelection == 7)
            {
                break;
            }
        }
    }
}