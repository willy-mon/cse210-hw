using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDecimal());

        Fractions f2 = new Fractions(5);
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDecimal());

        Fractions f3 = new Fractions(3,4);
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDecimal());

        Fractions f4 = new Fractions(1,3);
        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDecimal());
    }
}