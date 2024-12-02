using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        // breathingActivity.StartBreathingActivity();
        reflectionActivity.StartReflectionActivity();
    }

}