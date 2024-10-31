using System;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        Console.WriteLine($"Your name is: {name}\n");

        int x = 10;
        if (x > 15)
        {
            Console.WriteLine("Hey Bob");
        }

        string userInput = Console.ReadLine();
        int age = int.Parse(userInput);

        // this line sandwiches the two above lines into one 
        // int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your ages is: {age}");
    }
}


