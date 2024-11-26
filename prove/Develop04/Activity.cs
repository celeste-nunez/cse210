class Activity
{
    public static void ActivityIntroduction(string activityName, string activityDescription)
    {
        Console.WriteLine($"Welcome to the {activityName}\n");
        Console.WriteLine($"{activityDescription}\n");
    }

    public static void ActivityTimer()
    {
        Console.Write("How long, in seconds, would you like for your session? ");

        int timeInSeconds = int.Parse(Console.ReadLine());
        int timeInMilliseconds = timeInSeconds * 1000;

        Thread.Sleep(timeInMilliseconds);
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