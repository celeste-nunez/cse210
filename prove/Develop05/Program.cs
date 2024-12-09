using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!\n");

        SimpleGoal _simpleGoal = new SimpleGoal();
        EternalGoal _eternalGoal = new EternalGoal();
        Checklist _checklistGoal = new Checklist();
        
        while (true)
        {
            int responseInput = 0;

            Console.WriteLine("\n~~~Menu~~~");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Quit\n");
            Console.Write("Select your goal: ");
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
                foreach (var goal in Goal.GetGoals())
                {
                    Console.WriteLine(goal.ToString());
                }
            }
            if (responseInput == 5) 
            {
                break;
            }

        }
        
    }
}