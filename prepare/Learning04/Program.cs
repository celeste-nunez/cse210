using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Journal newJournal = new Journal();

        int menuSelection;
        do {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1) 
            {
                newJournal.CreateEntry();
                Console.WriteLine("New entry created!");
            }
            if (menuSelection == 2) 
            {
                Console.WriteLine("\nDisplaying journal entries:");
                newJournal.DisplayEntries();
            }
            if (menuSelection == 3) 
            {
                Console.Write("Input file name: ");
                string fileName = Console.ReadLine();
                newJournal.WriteToFile(fileName);
                Console.WriteLine($"Journal entries saved successfully to {fileName}.");
            }
            if (menuSelection == 4) 
            {
                Console.Write("Input file name: ");
                string fileName = Console.ReadLine();
                newJournal.ReadFromFile(fileName);
            }

        } while (menuSelection != 5);

    }
}
