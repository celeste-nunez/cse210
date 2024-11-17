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
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}