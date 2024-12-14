class Library 
{
    List<string> memberIDs = new List<string>{"M54321","M12345","M5678"};
    List<string> librarianIDs = new List<string>{"L5678"};
    
    public void Welcome()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Library!\n");
    }
    public string GetUserID()
    {
        Console.Write($"please insert your user ID: ");
        string userID =  Console.ReadLine();
        return userID;
    }

    public string IdentifyUserID(string userID)
    {
        userID = userID.ToUpper();
        if (memberIDs.Contains(userID))
        {
            string userType = "member";
            Console.WriteLine("Welcome to the library valued member!\n");
            return userType;
        }
        else if (librarianIDs.Contains(userID))
        {
            string userType = "librarian";
            Console.WriteLine("Welcome librarian!\n");
            return userType;
        }
        else 
        {
            string userType = "does not exist";
            Console.WriteLine($"The user {userID} does not exist");
            return userType;
        }
    }

    public void Loading()
    {
        int numberOfLoops = 0;

        while (numberOfLoops <2)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Console.Write("\b \b");
            numberOfLoops += 1;
        }
    }

}