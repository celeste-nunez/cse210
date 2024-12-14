class Transactions
{
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
}