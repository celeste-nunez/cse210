using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please input your grade percentage: ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade: {letter}");
        

        if (gradePercentage >70) 
        {
            Console.WriteLine("Congratulations! You passed the course. ");
        }
        else if (gradePercentage <70)
        {
            Console.WriteLine("Better luck next time. You failed the course.");
        }
    }
}