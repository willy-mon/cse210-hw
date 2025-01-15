using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Put the magic number: ");
        int magicNumber = int.Parse(Console.ReadLine());



        Random randomGenerator = new Random();
        int numberUser = randomGenerator.Next(1,101);

        int userNumber = -1;

        while (userNumber != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it!");
            }
        }
        
    }
}