class Member : User
{
    private Catalog _catalog;
    
    public Member(string userId, Catalog catalog) : base(userId, catalog)
    {
        _catalog = catalog;
    }
    public override void GetUserSelections()
    {
        while (true)
        {
            MemberMenu();
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (userSelection == 1) 
            {
                _borrowService.BorrowBook(UserID);
            }
            else if (userSelection == 2)
            {
                _borrowService.ReturnBook(UserID);
            }
            else if (userSelection == 3)
            {
                _borrowService.GetPersonalHistory(UserID);
            }
            else if (userSelection == 4)
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