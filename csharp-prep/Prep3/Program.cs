using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random rnd = new Random();

        string loop = "yes";
        int attempts = 1;

        while (loop == "yes")
        {
            int magicNumber = rnd.Next(1,10);
            int response = 0;
            // int response = int.Parse(initResponse);
        
            do 
            {
                Console.Write("What is the magic number? ");
                string responseInput = Console.ReadLine();
                response = int.Parse(responseInput);

                if (response < magicNumber)
                {
                    Console.WriteLine("Higher");
                    attempts += 1;
                }
                
                if (response > magicNumber) 
                {
                    Console.WriteLine("Lower");
                    attempts += 1;
                }

            }while (response != magicNumber);

            Console.WriteLine("You found the magic number!");
            Console.WriteLine($"Number of attempts: {attempts}");

            Console.Write("Do you want to continue? ");
            loop = Console.ReadLine();
        }
    }
}