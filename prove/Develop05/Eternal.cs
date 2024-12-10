using System.Drawing;

class EternalGoal : Goal
{
    public EternalGoal()
    {
        GoalType = "Eternal";
        Name = "";
        Description = "";
        Points = 0;
    }
    public EternalGoal(string name, string description, int points)
    {
        GoalType = "Eternal";
        Name = name;
        Description = description;
        Points = points;
    }
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
        PointsToAdd = Points;
        Console.WriteLine("Eternal goal progress recorded!");
    }
}