using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        MenuOptions menu = new MenuOptions();
        menu.GetMenu();

        string userInput = Console.ReadLine();

        while (userInput != "4")

        {
            if (userInput == "1")
            {
                BreathingActivity one = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                one.Run();
                menu.GetMenu();
                userInput = Console.ReadLine();

            }
            else if (userInput == "2")
            {
                List<string> prompts = new List<string>();

                prompts.Add("Who are people that you appreciate? ");
                prompts.Add("What are personal strengths of yours? ");
                prompts.Add("Who are people that you have helped this week? ");
                prompts.Add("When have you felt the Holy Ghost this month? ");
                ListingActivity two = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0, 0, prompts);
                two.Run();
                menu.GetMenu();
                userInput = Console.ReadLine();
            }
            else if (userInput == "3")
            {
                List<string> userOptions = new List<string>();
                List<string> userQuestions = new List<string>();

                userOptions.Add("Think of a time when you stood up for someone else. ");
                userOptions.Add("Think of a time when you did something really difficult.");
                userOptions.Add("Think of a time when you helped someone in need.");
                userOptions.Add("Think of a time when you did something truly selfless.");

                userQuestions.Add("Why was this experience meaningful to you? ");
                userQuestions.Add("Have you ever done anything like this before? ");
                userQuestions.Add("How did you get started? ");
                userQuestions.Add("How did you feel when it was complete? ");
                userQuestions.Add("What made this time different than other times when you were not as successful? ");
                userQuestions.Add("What is your favorite thing about this experience? ");
                userQuestions.Add("What could you learn from this experience that applies to other situations? ");
                userQuestions.Add("What did you learn about yourself through this experience? ");
                userQuestions.Add("How can you keep this experience in mind in the future? ");

                ReflectingActivity three = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 0, userOptions, userQuestions);
                three.Run();
                menu.GetMenu();
                userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It looks like you entered the wrong value. Please enter a new one again ");
                Thread.Sleep(8000);
                menu.GetMenu();
                userInput = Console.ReadLine();


            }

        }

        Console.WriteLine("Bye!");
        


        
    }
}