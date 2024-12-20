class Transactions
{
    public List <TransactionData> transactions = new List<TransactionData>{};
    public void recordEvent(string filename, string UserID, string transactionType, string bookTitle, string bookAuthor, string bookGenre, bool bookAvailibility, int bookID )
    {
        try
        {
            string transactionDate = DateTime.Now.ToString("yy-MM-dd");
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                string line = $"{UserID}~{transactionType}~{bookTitle}~{bookAuthor}~{bookGenre}~{bookAvailibility}~{bookID}";

                writer.WriteLine(line);
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while updating the file: {ex.Message}");
        }
    }

    public List<TransactionData> GetTransactions(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return transactions;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return transactions;
        }
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            var transactionData = line.Split('~');

            if (transactionData.Length >= 7)
            {
                string userID = transactionData[0].Trim();
                string transactionType = transactionData[1].Trim();
                string bookTitle = transactionData[2].Trim();
                string bookAuthor = transactionData[3].Trim();
                string bookGenre = transactionData[4].Trim();
                bool bookAvailability = bool.Parse(transactionData[5].Trim());
                int bookID = int.Parse(transactionData[6].Trim());


                TransactionData newTransaction = new TransactionData(userID,transactionType,bookTitle,bookAuthor,bookGenre,bookAvailability,bookID);
                transactions.Add(newTransaction);
            }
        }
        return transactions;
    }

    public void GetAnotherUsersHistory()
    {
        GetTransactions("TransactionRecords.txt");

        Console.Write("Please input the user's ID: ");
        string _userID = Console.ReadLine();

        var searchResults = transactions.Where(transaction => transaction.UserID.Contains(_userID)).ToList();

        if (searchResults.Count > 0)
        {
            Console.WriteLine("\n");
            foreach (var transaction in searchResults)
            {
                Console.WriteLine($"Action: {transaction.TransactionType}, Title: {transaction.TransactionBookTitle}, Author: {transaction.TransactionBookAuthor}, Genre: {transaction.TransactionBookGenre}, BookID: {transaction.TransactionBookID} ");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine($"Error: No results found");
        }
    }

    public void GetPersonalHistory(string _userID)
    {
        GetTransactions("TransactionRecords.txt");
        var searchResults = transactions.Where (transaction => transaction.UserID.Contains(_userID)).ToList();

        if (searchResults.Count > 0)
        {
            foreach (var transaction in searchResults)
            {
                Console.WriteLine($"Action: {transaction.TransactionType}, Title: {transaction.TransactionBookTitle}, Author: {transaction.TransactionBookAuthor}, Genre: {transaction.TransactionBookGenre}, BookID: {transaction.TransactionBookID} ");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine($"Error: No results found");
        }

    }
}