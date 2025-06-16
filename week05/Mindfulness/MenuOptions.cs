public class MenuOptions
{
    //Also a creativity extra! I created a class to print the menu every time that user goes for a different activity
    public MenuOptions()
    {

    }

    public void GetMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Project.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Listing Activity");
        Console.WriteLine("3. Start Reflecting Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
        Console.Write("Select a choice from the menu: ");
    }
}
