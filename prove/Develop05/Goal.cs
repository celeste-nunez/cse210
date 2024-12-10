using System.ComponentModel;

abstract class Goal 
{
    private static List<Goal> _goalsList = new List<Goal>();

    public string GoalType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; private set; }
    public int Progress { get; set; }
    public int BonusPoints { get; set; }
    public int ActualProgress { get; set; }

    public static void AddGoal(Goal newGoal)
    {
        _goalsList.Add(newGoal);
    }

    public static List<Goal> GetGoals()
    {
        return _goalsList;
    }

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

    public int GetProgress()
    {
        Console.Write("How many times would you like to accomplish this goal: ");
        int progress = int.Parse(Console.ReadLine());
        return progress;
    }

    public int GetBonusPoints()
    {
        Console.Write("How many points would you like to be attached to this goals completion: ");
        int bonus = int.Parse(Console.ReadLine());
        return bonus;
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
    public abstract void RecordEvent();
   

}
