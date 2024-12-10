class SaveLoad
{
    public void WriteToFile(string filename, bool append, int points)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, append))
        {
            outputFile.WriteLine(points);
            foreach(var goal in Goal.GetGoals())
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
    }
    public int ReadFromFile(string filename)
    {
        int runningTotal = 0;
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return runningTotal;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return runningTotal;
        }
        runningTotal = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            var goalData = line.Split('|');
            string goalType = goalData[0].Split(':')[1].Trim();
            string name = goalData[1].Split(':')[1].Trim();
            string description = goalData[2].Split(':')[1].Trim();
            int points = int.Parse(goalData[3].Split(':')[1].Trim());

            Goal newGoal;
            if (goalType == "Simple")
            {
                bool isComplete = goalData.Length > 4 && goalData[4].Split(':')[1].Trim() == "True";
                newGoal = new SimpleGoal(name, description, points, isComplete);
            }
            else if (goalType == "Eternal")
            {
                newGoal = new EternalGoal(name, description, points);
            }
            else if (goalType == "Checklist")
            {
                int progress = int.Parse(goalData[4].Split(':')[1].Trim().Split('/')[0]);
                int bonusPoints = int.Parse(goalData[5].Split(':')[1].Trim());
                bool isComplete = goalData.Length > 6 && goalData[6].Split(':')[1].Trim() == "True";
                newGoal = new ChecklistGoal(name, description, points, progress, bonusPoints, isComplete); 
            }
            else 
            {
                Console.WriteLine($"Unknown goal type: {goalType}");
                continue;
            }

            Goal.AddGoal(newGoal);

        }
        return runningTotal;
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