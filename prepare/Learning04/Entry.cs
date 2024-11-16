class Entry 
{

    public string Prompt { get; set; }
    public DateTime Date { get; set; }
    public string Content { get; set; }

    public Entry()
    {
        Prompt = GeneratePrompt();
        Date = DateTime.Now;
        Console.WriteLine("Input Entry: ");
        Content = Console.ReadLine();
    }

    public string GeneratePrompt()
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

    public override string ToString()
    {
        return $"Date: {Date:yyyy-MM-dd}\nPrompt: {Prompt}\nEntry: {Content}\n";
    }

    // public string FormatEntryOutput(string prompt, DateTime date, string entry)
    // {
    //     string outputString = "";
    //     outputString = $"{date}#{prompt}#{entry}";
    //     return outputString;
    // }
}