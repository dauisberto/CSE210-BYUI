public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like to do this activity? ");
        string userDuration = Console.ReadLine();
        int durationSeconds = int.Parse(userDuration);
        SetDuration(durationSeconds);

        ShowSpinner(10);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in");
            ShowCountDown(5);
            Console.WriteLine("Breathe out");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        Console.Clear();
        Console.WriteLine("Nice job!");
        ShowSpinner(13);
        DisplayEndingMessage();
        ShowSpinner(13);
        Console.Clear();
    }

    
}