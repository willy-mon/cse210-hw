using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's you're name? ");
        string name = Console.ReadLine();

        Console.Write("What's you're second name? ");
        string secondName = Console.ReadLine();
        
        Console.WriteLine($"My name is {secondName}, {name} {secondName}.");
    }
}