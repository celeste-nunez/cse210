class Librarian : User
{
    private string librarianID;
    public string PassLibrarianID(string _userID)
    {
        string librarianID = _userID;
        return librarianID;
    }

    public override void GetUserSelections()
    {
        Catalog LibrarianCatalog = getLibraryCatalog();
        BorrowService borrowService = new BorrowService
        (LibrarianCatalog);
        while (true)
        {
            LibrarianMenu();
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (userSelection == 1)
            {
               borrowService.BorrowBook(librarianID);
            }
            if (userSelection == 2)
            {
                borrowService.ReturnBook(librarianID);
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

        }


    }
}