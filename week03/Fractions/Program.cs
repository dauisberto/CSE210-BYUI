using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! This is the Fractions Project.");

        Fractions user_fraction = new Fractions();
        Fractions user_fraction2 = new Fractions(5);
        Fractions user_fraction3 = new Fractions(3, 4);
        Fractions user_fraction4 = new Fractions(1, 3);

        Console.WriteLine($"{user_fraction.GetFractionString()}");
        Console.WriteLine($"{user_fraction.GetDecimalValue()}");
        Console.WriteLine($"{user_fraction2.GetFractionString()}");
        Console.WriteLine($"{user_fraction2.GetDecimalValue()}");
        Console.WriteLine($"{user_fraction3.GetFractionString()}");
        Console.WriteLine($"{user_fraction3.GetDecimalValue()}");
        Console.WriteLine($"{user_fraction4.GetFractionString()}");
        Console.WriteLine($"{user_fraction4.GetDecimalValue()}");

        
    }
}