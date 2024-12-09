class SimpleGoal : Goal
{
    public override void RunGoal()
    {
        Console.WriteLine("Creating a Simple Goal...");
        Name = GetName();
        Description = GetDescription();
        Points = GetPoints();
        GetStatus();
        Console.WriteLine("Simple Goal Created Successfully!\n");
    }

    public override string ToString()
    {
        return $"Goal Type: Simple | Name: {Name} | Description: {Description} | Points: {Points} | Completed: {IsComplete}";
    }

}