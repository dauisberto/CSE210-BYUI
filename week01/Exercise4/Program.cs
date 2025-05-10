using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the List-o-rama");
        Console.WriteLine("Our objective today will be to include values in a list and give you");
        Console.WriteLine("some information about it.");
        Console.WriteLine("");
        Console.WriteLine("Let's go!");
        Console.WriteLine("");

        string user_option = "";
        int user_number = 0;
        int counter=0;
        int sum =0;
        int max=0;
        
        Console.WriteLine("IMPORTANT: 0 will be considered as the command to stop adding numbers");
        Console.Write("What is the first number you'd like to add to the list? ");
        
        user_option=Console.ReadLine();
        user_number=int.Parse(user_option);
        
        List<int> numbers = new List<int>();

        while (user_number!=0)
        {
            numbers.Add(user_number);
            counter=counter+1;
            if (user_number>max)
            {
                max = user_number;
            }
            
            Console.WriteLine("");
            Console.WriteLine("Great. Now what number would you like to add? ");
            user_option=Console.ReadLine();
            user_number=int.Parse(user_option);
        }

        foreach (int item in numbers)
        {
            sum=sum+item;
        }

        float average=((float)sum)/counter;

        Console.WriteLine("");
        Console.WriteLine("Ok! Thanks for using our app, now let's show you some info");
        Console.WriteLine("");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The average is: {average}");



    }
}