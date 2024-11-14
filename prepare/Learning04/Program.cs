using System;

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
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1) {}
            if (menuSelection == 2) {}
            if (menuSelection == 3) {}
            if (menuSelection == 4) {}


        } while (menuSelection != 5);

    }
}
