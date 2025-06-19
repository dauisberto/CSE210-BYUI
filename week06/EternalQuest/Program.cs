using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string userInput;
        userInput = "";
        string tempName;
        string tempDescription;
        string tempPoints;
        int tempTarget;
        int tempBonus;
        string userNewGoal;

        while (userInput != "6")
        {
            manager.Start();
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("What type of goal would you like to create? ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");


                userNewGoal = Console.ReadLine();

                if (userNewGoal == "1")
                {
                    Console.WriteLine("What's the name of your goal? ");
                    tempName = Console.ReadLine();
                    Console.WriteLine("What's the description of your goal? ");
                    tempDescription = Console.ReadLine();
                    Console.WriteLine("How many points are related to that goal? ");
                    tempPoints = Console.ReadLine();

                    Goal tempGoal = new SimpleGoal(tempName, tempDescription, tempPoints);
                    manager.CreateGoal(tempGoal);

                }
                else if (userNewGoal == "2")
                {
                    Console.WriteLine("What's the name of your goal? ");
                    tempName = Console.ReadLine();
                    Console.WriteLine("What's the description of your goal? ");
                    tempDescription = Console.ReadLine();
                    Console.WriteLine("How many points are related to that goal? ");
                    tempPoints = Console.ReadLine();

                    Goal tempGoal = new EternalGoal(tempName, tempDescription, tempPoints);
                    manager.CreateGoal(tempGoal);
                }
                else if (userNewGoal == "3")
                {
                    Console.WriteLine("What's the name of your goal? ");
                    tempName = Console.ReadLine();
                    Console.WriteLine("What's the description of your goal? ");
                    tempDescription = Console.ReadLine();
                    Console.WriteLine("How many points are related to that goal? ");
                    tempPoints = Console.ReadLine();
                    Console.WriteLine("How many times you want to do that goal? ");
                    tempTarget = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much is the bonus for that goal? ");
                    tempBonus = int.Parse(Console.ReadLine());
                    Goal tempGoal = new ChecklistGoal(tempName, tempDescription, tempPoints, tempTarget, tempBonus);
                    manager.CreateGoal(tempGoal);
                }
                else
                {
                    //Creativity: Adding a data validator in case user types something wrong!
                    Console.WriteLine("Oops! It looks like you wrote a wrong option");
                }
            }
            else if (userInput == "2")
            {
                manager.ListGoalDetails();
            }
            else if (userInput == "3")
            {
                string userFileName;
                Console.WriteLine("What's the name of the file? ");
                userFileName = Console.ReadLine();
                manager.SaveGoals(userFileName);

            }
            else if (userInput == "4")
            {
                string userFileName;
                Console.WriteLine("What's the name of the file? ");
                userFileName = Console.ReadLine();
                manager.LoadGoals(userFileName);

            }
            else if (userInput == "5")
            {
                Console.WriteLine("What action did you completed? ");
                manager.ListGoalNames();
                Console.WriteLine("Enter the number ");
                int userIndex;
                userIndex = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(userIndex);
            }
            else if (userInput != "6")
            {
                //Creativity: Adding a data validator in case user types something wrong!
                Console.WriteLine("Oops! It looks like you wrote a wrong option");
            }


        }

        Console.WriteLine("Bye!");
            

    }
}