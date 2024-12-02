class Listing : Activity 
{
    string activityName = "Listing Activity";
    string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";

    List<string> reflectionPrompts = new List<string>
    {
        "When have you felt proud of yourself this month",
        "When did you do something you felt was challenging this month",
        "When did you take time to yourself this month"
    };

    private string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(reflectionPrompts.Count);
        string randPrompt = reflectionPrompts[index];
        Console.WriteLine(randPrompt);
        return randPrompt;
    }

    public void startListingActivity()
    {
        ActivityIntroduction(activityName, activityDescription);
        int inputTime = GetTimeInSeconds();
        int sessionTime = inputTime;
        int totalTime = inputTime;
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        ActivityDelay();
        Console.WriteLine("\n");
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GeneratePrompt();
        while (sessionTime > 0)
        {
            Console.ReadLine();
            sessionTime -= 3;
        }
        ActivitySummary(totalTime, activityName);
    }


}