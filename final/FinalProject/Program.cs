using System;

class Program
{
    static Library ourLibrary = new Library();
    static Librarian ourLibrarians = new Librarian();
    static Member ourMembers = new Member();
    static void Main(string[] args)
    {
        ourLibrary.Welcome();
        string _userID = ourLibrary.GetUserID();
        ourLibrary.Loading();
        string _userType = ourLibrary.IdentifyUserID(_userID);
        if (_userType == "librarian") 
        {
            ourLibrarians.GetUserSelections();
            ourLibrarians.PassLibrarianID(_userID);
        }
        else if (_userType == "member")
        {
            ourMembers.GetUserSelections();
        }
        else 
        {
            Console.WriteLine($"invalid user ID, {_userID}");
        }

    }
}