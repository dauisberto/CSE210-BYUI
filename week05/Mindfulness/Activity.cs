using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You completed {_duration} seconds of {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();

        spinner.Add("W");
        spinner.Add("a");
        spinner.Add("i");
        spinner.Add("t");
        spinner.Add(".");
        spinner.Add(".");
        spinner.Add(".");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            i++;

            if (i >= 7)
            {
                //Creativity: I just looked how to clear the line instead of clearing the console to create
                // the spinner as a "Wait..." animation.
                int currentLine = Console.CursorTop;
                Console.SetCursorPosition(0, currentLine);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLine);
                i = 0;
            }



        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.WriteLine("");

    }

    public void ShowCountDown(int seconds)
    {

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 6;

        while (DateTime.Now < endTime)
        {
            Console.Write(i - 1);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;


            if (i <= 1)
            {
                i = 6;
            }
        }
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
            
    }