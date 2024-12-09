using System.ComponentModel;

abstract class Goal 
{
    private static List<Goal> _goalsList = new List<Goal>();

    public static void AddGoal(Goal newGoal)
    {
        _goalsList.Add(newGoal);
    }

    public static List<Goal> GetGoals()
    {
        return _goalsList;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; private set; }

    public string GetName()
    {
        Console.Write("What is the name of your goal: ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string GetDescription()
    {
        Console.Write("What is a short description of your goal: ");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }

    public int GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal: ");
        int goalPoints = int.Parse(Console.ReadLine());
        return goalPoints; 
    }

    public void GetStatus()
    {
        IsComplete = false;
    }

    public void MarkComplete()
    {
        IsComplete = true;
    }

    public abstract void RunGoal();

}
