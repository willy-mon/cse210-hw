using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (number >= 70)
        {
            Console.WriteLine($"Congratulations, you passed with a {letter} grade");
        }

        else
        {
            Console.WriteLine($"Try again you don't pass, you have a {letter}");
        }
        
    }
}