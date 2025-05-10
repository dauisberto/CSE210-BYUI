using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int square_number = SquareNumber(user_number);
        DisplayResult(user_name,square_number);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to our BYUI App! ");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your Name? ");
        string name_typing = Console.ReadLine();
        return name_typing;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string string_number = Console.ReadLine();
        int fav_number=int.Parse(string_number);
        return fav_number;
    }
    static int SquareNumber(int numb)
    {
        int square = numb*numb;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your squared number is {square}");
    }
        
    
}