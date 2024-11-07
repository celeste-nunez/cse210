using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int numberInput = 1;
        Console.WriteLine("Enter a list of numbers, write 0 when finished");

        do 
        {   
            Console.Write("Enter a number: ");
            numberInput = int.Parse(Console.ReadLine());
            numbers.Add(numberInput);

        }while (numberInput != 0);

        int total = numbers.Sum();
        Console.WriteLine($"sum: {total}");

        double length = numbers.Count();
        double average = total/length;
        Console.WriteLine($"average: {average}");
    }
}