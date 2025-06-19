using System.IO;
public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine("");
        Console.WriteLine("Menu options: ");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points");
    }

    public void ListGoalDetails()
    {
        int index;
        index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}.{g.GetDetailsString()}");
            index++;

        }
    }

    public void ListGoalNames()
    {
        int counter;
        counter = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.GetGoalName()}");
            counter++;
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        _goals[goalIndex].RecordEvent();
        Goal userGoal = _goals[goalIndex];
        int points;
        points = int.Parse(userGoal.GetPoints());
        int bonus;
        bonus = 0;

        if (userGoal is ChecklistGoal usercheckGoal)
        {
            if (userGoal.IsComplete())
            {
                bonus = usercheckGoal.GetBonus();
            }

            _score += bonus + points;
        }
        else
        {
            _score += + points;
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine($"{g.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] data = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goalFromList = new SimpleGoal(data[0], data[1], data[2]);
                CreateGoal(goalFromList);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goalFromList = new EternalGoal(data[0], data[1], data[2]);
                CreateGoal(goalFromList);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goalFromList = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]));
            }

        }
    }








}