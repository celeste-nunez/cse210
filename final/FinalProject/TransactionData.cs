class TransactionData
{
    public string UserID { get; set;}
    public string TransactionType { get; set;}
    public string TransactionBookTitle { get; set;}
    public string TransactionBookAuthor { get; set;}
    public string TransactionBookGenre { get;set;}
    public bool TransactionBookAvailability { get;set;}
    public int TransactionBookID { get;set;}


    public TransactionData(string _userID, string _transactionType, string _transactionBooktitle, string _transactionBookAuthor, string _transactionBookGenre, bool _transactionBookAvailability, int _transactionBookID)
    {
        UserID = _userID;
        TransactionType = _transactionType;
        TransactionBookTitle = _transactionBooktitle;
        TransactionBookAuthor = _transactionBookAuthor;
        TransactionBookGenre = _transactionBookGenre;
        TransactionBookAvailability = _transactionBookAvailability;
        TransactionBookID = _transactionBookID;
    }

}