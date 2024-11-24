using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture.ReadScripture();
        Console.WriteLine("\nPress enter to continue or type quit to finish");

        string quit = Console.ReadLine();
        
        do
        {
            Console.Clear();
            Scripture.HideScriptureWords();
            Console.WriteLine("\n\nPress enter to continue or type quit to finish");
            quit = Console.ReadLine();

        } while (quit != "quit" && quit != "q");

        Console.WriteLine("\nthank you");
        
    }
}