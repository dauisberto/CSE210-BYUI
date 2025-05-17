public class Entry
{
    public string _changeDate ="";
    public string _promptText="";
    public string _entryText="";

    public Entry()
    {

    }

    public void DisplayEntry()

    {
        Console.WriteLine($"Date: {_changeDate} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }

}