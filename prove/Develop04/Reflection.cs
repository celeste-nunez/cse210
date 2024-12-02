using System.Diagnostics;

class Reflection : Activity 
{
    string activityName = "Reflection Activity";
    string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

   List<string> Prompts = new List<string>
   {
    "Recall a time when you overcame a significant challenge.",
    "Describe a moment when you felt truly proud of yourself.",
    "Think about a time when you had to make a tough decision.",
    "Reflect on a situation where you learned an important lesson.",
    "Share an experience where you helped someone in need.",
    "Consider a moment when you received unexpected kindness.",
    "Write about a time when you stepped out of your comfort zone.",
    "Recall an instance when you failed but grew from the experience.",
    "Think of a time when you worked as part of a successful team.",
    "Reflect on a situation that changed your perspective on something important."
   };

   List<string> followUpQuestions = new List<string>
    {
        "How did you feel when this was complete?",
        "What was your favorite thing about this experience?",
        "What challenges did you face during this time?",
        "What did you learn from this experience?",
        "How has this shaped who you are today?",
        "Would you approach this situation differently in the future? Why or why not?",
        "What advice would you give someone in a similar situation?",
        "What did you discover about yourself through this process?",
        "How did this experience impact the people around you?",
        "What emotions did you experience during this moment?"
    };

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        string randPrompt = Prompts[index];
        Console.WriteLine(randPrompt);
        return randPrompt;
    }
    public string GenerateFollowUpQuestions()
    {
        Random random = new Random();
        int index = random.Next(followUpQuestions.Count);
        string randPrompt = followUpQuestions[index];
        Console.WriteLine(randPrompt);
        return randPrompt;
    }

    public void StartReflectionActivity()
    {
        ActivityIntroduction(activityName, activityDescription);
        int inputTime = GetTimeInSeconds();
        DateTime endTime = activityDuration(inputTime);
        int totalTime = inputTime;
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        ActivityDelay();
        Console.WriteLine("\n");
        Console.WriteLine("Consider the following prompt: ");
        GeneratePrompt();
        Console.WriteLine("when you have something in mind, press Enter to continue...");
        Console.ReadLine();

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            GenerateFollowUpQuestions();
            ActivityDelay();
        }
        ActivitySummary(totalTime, activityName);
    }

}