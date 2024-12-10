class ChecklistGoal : Goal
{
    public ChecklistGoal()
    {
        GoalType = "Simple";
        Name = "";
        Description = "";
        Points = 0;
        Progress = 3;
        BonusPoints = 0;
        IsComplete = false;
        ActualProgress = 0;
    }

    public ChecklistGoal(string name, string description, int points, int progress, int bonusPoints, bool isComplete)
    {
        GoalType = "Checklist";
        Name = name;
        Description = description;
        Points = points;
        Progress = progress;
        BonusPoints = bonusPoints;
        IsComplete = isComplete;
    }
     public override void RunGoal()
    {
        Console.WriteLine("Creating a Checklist Goal...");
        GoalType = "Checklist";
        Name = GetName();
        Description = GetDescription();
        Points = GetPoints();
        Progress = GetProgress();
        BonusPoints = GetBonusPoints();
        GetStatus();
        Console.WriteLine("Checklist Goal Created Successfully!\n");
        ActualProgress = 0;
    }

    public override string ToString()
    {
        return $"Goal Type: {GoalType} | Name: {Name} | Description: {Description} | Points per completion: {Points} | Progress: {ActualProgress}/{Progress} | Bonus Points: {BonusPoints} | Completed: {IsComplete}";
    }

    public override void RecordEvent()
    {
        ActualProgress += 1;
        PointsToAdd = Points;
        if (ActualProgress == Progress)
        {
            PointsToAdd = Points + BonusPoints;
            Console.WriteLine("Checklist progress added!");
            Console.WriteLine("Checklist Completed!");
            MarkComplete();
        }
        if (ActualProgress != Progress)
        {
            PointsToAdd = Points;
            Console.WriteLine("Checklist progress added!");
        }

    }

}