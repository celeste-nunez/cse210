using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello Sandbox World!");


    //     Console.WriteLine("Please enter your name");
    //     string name = Console.ReadLine();

    //     Console.WriteLine($"Your name is: {name}\n");

    //     int x = 10;
    //     if (x > 15)
    //     {
    //         Console.WriteLine("Hey Bob");
    //     }

    //     string userInput = Console.ReadLine();
    //     int age = int.Parse(userInput);

    //                             // this line sandwiches the two above lines into one 
    //                             // int age = int.Parse(Console.ReadLine());

    //     Console.WriteLine($"Your ages is: {age}"); 
    // }

    // static int AddNumbers (int n1, int n2)
    // {
    //     int total = n1 + n2;
    //     return total;
    // }
    // static void Main (string[] args)
    // {
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // };

        // int age = -1;
        // while (age < 0 || age > 125)
        // {
        //     Console.WriteLine("Please enter your age: (0-125)");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // };

        // int age;
        // do 
        // {
        //     Console.WriteLine("Please enter your age: (0-125)");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // } while (age < 0 || age > 125);

    //     List <string> myColors = new List<string>();
    //     myColors.Add("red");
    //     myColors.Add("orange");
    //     myColors.Add("yellow");
    //     myColors.Add("green");
    //     myColors.Add("blue");

    //     foreach (string color in myColors)
    //     {
    //         Console.WriteLine(color);
    //     }

    //     int total  = AddNumbers(20, 30);
    //     Console.WriteLine(total);

    // }

    static void Main(string[] args)
    {
        int x = 10;
        int y = x++;
        Console.WriteLine($"{y}, {x}");

        int z = ++y;
        Console.WriteLine($"{z}, {y}");
    }
}