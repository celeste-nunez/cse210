using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static Library ourLibrary = new Library();
    // static Librarian ourLibrarians = new Librarian();
    // static Member ourMembers = new Member();
    static void Main(string[] args)
    {
        Catalog libraryCatalog = new Catalog();
        libraryCatalog.GetBooks("BooksList.txt");

        ourLibrary.Welcome();
        string userId = ourLibrary.GetUserID();
        ourLibrary.Loading();
        string _userType = ourLibrary.IdentifyUserID(userId);
        if (_userType == "librarian") 
        {
            Librarian librarian = new Librarian(userId, libraryCatalog);
            librarian.GetUserSelections();
        }
        else if (_userType == "member")
        {
            Member member = new Member(userId, libraryCatalog);
            member.GetUserSelections();
        }
        else 
        {
            Console.WriteLine($"invalid user ID, {userId}");
        }

    }
}