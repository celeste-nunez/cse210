class Librarian : User
{

    public override void GetUserSelections()
    {
        Catalog LibrarianCatalog = getLibraryCatalog();
        while (true)
        {
            LibrarianMenu();
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (userSelection == 1)
            {
                LibrarianCatalog.BorrowBook();
            }
            if (userSelection == 8)
            {
                break;
            }

        }


    }
}