class Transactions
{
    private void UpdateTransactionsFile(string filename)
    {
        try
        {
            string transactionDate = DateTime.Now.ToString("");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (var book)
                {
                    string line = $"{book.Title}~{book.Author}~{book.Genre}~{book.Availability}~{book.BookID}~{transactionDate}";
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while updating the file: {ex.Message}");
        }
    }
}