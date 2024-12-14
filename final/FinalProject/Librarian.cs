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
        // Catalog LibrarianCatalog = getLibraryCatalog();
        // BorrowService borrowService = new BorrowService
        // (LibrarianCatalog);
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
                
            }
            if (userSelection == 4)
            {
                
            }
            if (userSelection == 5)
            {
                
            }
            if (userSelection == 6)
            {
                
            }
            if (userSelection == 7)
            {
                
            }
            if (userSelection == 8)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.\n");
            }


        }


    }
}