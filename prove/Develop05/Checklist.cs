class Checklist : Goal
{
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
        return $"Goal Type: {GoalType} | Name: {Name} | Description: {Description} | Points per completion: {Points} | Bonus Points: {BonusPoints} | Progress: {ActualProgress}/{Progress} | Completed: {IsComplete}";
    }

    public override void RecordEvent()
    {
        
    }

}