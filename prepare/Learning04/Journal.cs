class Journal 
{ 
    private List<Entry> entries = new List<Entry>();
    public void CreateEntry()
    {
        Entry newEntry = new Entry();
        entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}