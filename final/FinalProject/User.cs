using Microsoft.VisualBasic;

abstract class User
{
    List<string> memberIDs = new List<string>{"M54321","M12345","M5678"};
    List<string> librarianIDs = new List<string>{"L5678"};
    public string GetUserID()
    {
        Console.Write($"please insert your user ID: ");
        string userID =  Console.ReadLine();
        return userID;
    }

    public string IdentifyUserID(string userID)
    {
        userID = userID.ToLower();
        if (memberIDs.Contains(userID))
        {
            string userType = "member";
            Console.WriteLine("Welcome to the library valued member!");
            return userType;
        }
        else if (librarianIDs.Contains(userID))
        {
            string userType = "librarian";
            Console.WriteLine("Welcome librarian!");
            return userType;
        }
        // else 
        // {
        //     Console.WriteLine($"The userID: {userID} does not exist");
            
        // }
    }

    protected abstract void GetUserSelections();
}