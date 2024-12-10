class SaveLoad
{
    public void WriteToFile(string filename, bool append)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, append))
        {
            foreach(var goal in Goal.GetGoals())
            {
                outputFile.WriteLine(goal.ToString());
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

    public void SelectionMenu()
    {
        Console.WriteLine("\n~~~Menu~~~");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. List Goals");
        Console.WriteLine("5. Save Goal");
        Console.WriteLine("6. Load Goal");
        Console.WriteLine("7. Record Event");
        Console.WriteLine("8. quit");
        Console.Write("Select your goal: ");
    }
}