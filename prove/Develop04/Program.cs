using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listingActivity = new Listing();

        int response;

        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflection activity");
            Console.WriteLine("   3. Start listing acctivity");
            Console.WriteLine("   4. Quit");
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
        } while (response != 4);

    }



}