class Activity
{
    public static void ActivityIntroduction(string activityName, string activityDescription)
    {
        Console.WriteLine($"Welcome to the {activityName}\n");
        Console.WriteLine($"{activityDescription}\n");
    }

    public static int GetTimeInSeconds()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int timeInSeconds = int.Parse(Console.ReadLine());
        return timeInSeconds;
    }

    public DateTime activityDuration(int timeInSeconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(timeInSeconds);
        return endTime;
    }


    public static void ActivitySummary(int timeInSeconds, string activityName)
    {
        Console.WriteLine($"You have completed another {timeInSeconds} seconds of the {activityName}.");
    }

    public static void ActivityDelay()
    {
        int numberOfLoops = 0;

        while (numberOfLoops <3)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Console.Write("\b \b");
            numberOfLoops += 1;
        }
    }
}