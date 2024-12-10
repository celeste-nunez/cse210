using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int runningTotal = 0;
        Console.WriteLine("Hello Develop05 World!\n");

        SimpleGoal _simpleGoal = new SimpleGoal();
        EternalGoal _eternalGoal = new EternalGoal();
        Checklist _checklistGoal = new Checklist();
        SaveLoad _saveLoad = new SaveLoad();
        string GoalType = _eternalGoal.GoalType;
        while (true)
        {
            int responseInput = 0;
            Console.WriteLine($"\nRunning Point Total: {runningTotal}");

            _saveLoad.SelectionMenu();

            responseInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (responseInput == 1)
            {
                _simpleGoal.RunGoal();
                Goal.AddGoal(_simpleGoal);
            }
            if (responseInput == 2)
            {
                _eternalGoal.RunGoal();
                Goal.AddGoal(_eternalGoal);
            }
            if (responseInput == 3)
            {
                _checklistGoal.RunGoal();
                Goal.AddGoal(_checklistGoal);
            }
            if (responseInput == 4)
            {
                Console.WriteLine("Goals in your list:");
                int i = 0;
                foreach (var goal in Goal.GetGoals())
                {
                    Console.WriteLine($"{++i}. {goal.ToString()}");
                }
            }
            if (responseInput == 5) 
            {
                Console.Write("Insert filename: ");
                string _filename = Console.ReadLine();
                _saveLoad.WriteToFile(_filename, false);
                Console.WriteLine($"Journal entries saved successfully to {_filename}.");
            }
            if (responseInput == 6)
            {
                Console.Write("Insert filename: ");
                string _filename = Console.ReadLine();
                _saveLoad.ReadFromFile(_filename);
            }
            if (responseInput == 7)
            {
                int i = 0;
                var goals = Goal.GetGoals();
                foreach (var goal in goals)
                {
                    Console.WriteLine($"{++i}. {goal.ToString()}");
                }

                Console.Write("Select a goal: ");
                int indexToEdit = int.Parse(Console.ReadLine()) -1;

                if (indexToEdit >= 0 && indexToEdit < goals.Count)
                {
                    var selectedGoal = goals[indexToEdit];
                    var goalType = selectedGoal.GoalType;

                    if (goalType == "Simple")
                    {
                        Console.Write("Is this goal complete(y/n): ");
                        string userCompletionConfirmation = Console.ReadLine();
                        if (userCompletionConfirmation == "y")
                        {
                            _simpleGoal.RecordEvent();
                            runningTotal += selectedGoal.PointsToAdd;
                        }
                    }
                    if (goalType == "Eternal")
                    {
                        Console.Write("Is this goal complete(y/n): ");
                        string userCompletionConfirmation = Console.ReadLine();
                        if (userCompletionConfirmation == "y")
                        {
                            _eternalGoal.RecordEvent();
                            runningTotal += selectedGoal.PointsToAdd; 
                        }
                    }
                    if (goalType == "Checklist")
                    {
                        Console.Write("Has this goal progressed(y/n): ");
                        string userCompletionConfirmation = Console.ReadLine();
                        if (userCompletionConfirmation == "y")
                        {
                            _checklistGoal.RecordEvent();
                           runningTotal += selectedGoal.PointsToAdd;
                        }
                    }
                }
            } 
            if (responseInput == 8)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break; 
            }
        }
    }
}
