using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    public void printMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflection activity");
        Console.WriteLine("   3. Start listing acctivity");
        Console.WriteLine("   4. Quit");
    }
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listingActivity = new Listing();

        int response;

        do
        {
            response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                breathingActivity.StartBreathingActivity();
            }
            if (response == 2)
            {
                reflectionActivity.StartReflectionActivity();
            }
            if (response == 3)
            {
                listingActivity.startListingActivity();
            }
            else 
            {
                Console.Write("Invalid input");
            }

        } while (response != 4);

    }

}