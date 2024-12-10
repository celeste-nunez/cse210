class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        GoalType = "Simple";
        Name = "";
        Description = "";
        Points = 0;
        IsComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete)
    {
        GoalType = "Simple";
        Name = name;
        Description = description;
        Points = points;
        IsComplete = isComplete;
    }
    public override void RunGoal()
    {
        Console.WriteLine("Creating a Simple Goal...");
        GoalType = "Simple";
        Name = GetName();
        Description = GetDescription();
        Points = GetPoints();
        GetStatus();
        Console.WriteLine("Simple Goal Created Successfully!\n");
    }

    public override string ToString()
    {
        return $"Goal Type: {GoalType} | Name: {Name} | Description: {Description} | Points: {Points} | Completed: {IsComplete}";
    }

    public override void RecordEvent()
    {
        MarkComplete();
        PointsToAdd = Points;
        Console.WriteLine("Simple goal completed!");
    }
}