class SimpleGoal : Goal
{
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