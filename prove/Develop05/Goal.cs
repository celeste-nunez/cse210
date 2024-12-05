using System.ComponentModel;

abstract class Goal 
{
    private List<Goal> _goalsList;
    static string GetName()
    {
        Console.Write("What is the name of your goal: ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    static private string GetDescription()
    {
        Console.Write("What is a short description of your goal: ");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }

    static public string SetDescription(string description)
    {
        string _description = description;
        return _description;
    }

    static private int GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal: ");
        int goalPoints = int.Parse(Console.ReadLine());
        return goalPoints; 
    }

    static public int SetPoints(int points)
    {
        int _points = points;
        return _points;
    }

    static private bool GetStatus()
    {
        bool status = false;
        return status;
    }

    static private bool MarkComplete()
    {
        bool status = true;
        return status;
    }
    
    static List<Goal> ListGoal(Goal leGoal)
    {
        List<Goal> _goalsList = new List<Goal>{};
        _goalsList.Add(leGoal);
        return _goalsList;
    }

    static string ToString(string name, string description, bool complete)
    {
        string _complete = "";
        string formattedGoal = "";

        if (complete == true)
        { _complete = "X";}
        else
        {_complete = " ";}

        formattedGoal = ($"[{_complete}] name ({description})");
        
        return formattedGoal;
    }

    // static abstract RunGoal()
    // {
    //     GetName();
    //     GetDescription();
    //     GetPoints();
        
    // }



}
