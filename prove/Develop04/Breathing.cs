class Breathing : Activity
{
    Activity breathingActivity = new Activity();
    string activityName = "Breathing Activity";
    string activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.";

    public void BreathIn()
    {
        Console.Write("Breathe in...");
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(2);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();
    }

    public void BreathOut()
    {
        Console.Write("Now breathe out...");
        Console.Write(6);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(5);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(2);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine(" \n");
    }

    public void StartBreathingActivity()
    {
        ActivityIntroduction(activityName, activityDescription);
        int inputTime = GetTimeInSeconds();
        int sessionTime = inputTime;
        int totalTime = inputTime;
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        ActivityDelay();
        Console.WriteLine("\n");
        while (sessionTime > 0)
        {
            BreathIn();
            sessionTime -= 4;
            BreathOut();
            sessionTime -= 6;
        }
        ActivitySummary(totalTime, activityName);
    }

}