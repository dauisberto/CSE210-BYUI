public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            string userResponse = Console.ReadLine();
            userList.Add(userResponse);
        }

        return userList;
    }

    public void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(1, 5);
        Console.WriteLine($"{_prompts[randomIndex]}");
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

        Console.WriteLine("List as many responses you can to the following prompt ");
        GetRandomPrompt();
        Console.WriteLine("");
        ShowCountDown(3);
        List<string> userResponse = GetListFromUser(_duration);
               
    
        Console.Clear();
        Console.WriteLine("Nice job!");
        ShowSpinner(13);
        Console.WriteLine($"You completed {userResponse.Count} items");
        DisplayEndingMessage();
        ShowSpinner(13);
        Console.Clear();
    }

}