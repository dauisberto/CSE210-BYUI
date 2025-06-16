public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(1, 4);
        string promptReturn = _prompts[randomIndex];
        return promptReturn;
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int randomQuestionIndex = randomQuestion.Next(1, 9);
        string questionReturn = _questions[randomQuestionIndex];
        return questionReturn;
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

        Console.WriteLine("Consider the following prompt: ");

        Console.WriteLine($"...{GetRandomPrompt()}...");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine("");
        Console.WriteLine("Press enter when you feel free to go ");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        ShowCountDown(6);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"{GetRandomQuestion()} ");
            ShowSpinner(8);
        }

        DisplayEndingMessage();


 
    }

    
}