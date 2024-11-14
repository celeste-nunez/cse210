class Entry 
{
    public Entry()
    {
        string prompt = Prompt();
        DateTime date = EntryDateTime();
        string entry = InputEntry();

        FormatEntryOutput(prompt, date, entry);
    }

    public string Prompt()
    {
        List<string> prompts = new List<string>();

        prompts.Add("What are three things I’m grateful for today?");
        prompts.Add("What are some areas of my life where I feel I could improve?");
        prompts.Add("What does my ideal day look like, from morning to night?");
        prompts.Add("How do I want others to remember me?");
        prompts.Add("What’s one thing I need to let go of to move forward?");

        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randPrompt = prompts[index];
        Console.WriteLine(randPrompt);
        return randPrompt;
    }

    public DateTime EntryDateTime() 
    {
        DateTime entryDateTime = DateTime.Now;
        return entryDateTime;
    }

    public string InputEntry()
    {
        string entry = Console.ReadLine();
        return entry;
    }

    public string FormatEntryOutput(string prompt, DateTime date, string entry)
    {
        string entryOutput = $"{prompt}\n{date}\n{entry}";
        Console.WriteLine(entryOutput);
        return entryOutput;
    }
}