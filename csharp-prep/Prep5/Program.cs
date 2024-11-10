using System;
using System.Net;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        double number = double.Parse(Console.ReadLine());
        return number;
    }
    static double SquareNumber(double number)
    {
        double square = number * number;
        return square;
    }
    static void DisplayResult(double square, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        double favoriteNumber = PromptUserNumber();
        double square = SquareNumber(favoriteNumber);
        DisplayResult(square, name);



    }
}