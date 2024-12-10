class EternalGoal : Goal
{
    public override void RunGoal()
    {
        Console.WriteLine("Creating an Eternal Goal...");
        GoalType = "Eternal";
        Name = GetName();
        Description = GetDescription();
        Points = GetPoints();
        Console.WriteLine("Eternal Goal Created Successfully!\n");
    }

    public override string ToString()
    {
        return $"Goal Type: {GoalType} | Name: {Name} | Description: {Description} | Points: {Points}";
    }
    
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}