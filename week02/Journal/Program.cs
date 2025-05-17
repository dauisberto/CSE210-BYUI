using System;

class Program
{
    static void Main(string[] args)
    {
        
        Journal user_journal = new Journal();
        PromptGenerator user_prompt = new PromptGenerator();
        List<Entry> user_entries = new List<Entry>();
        
        Console.WriteLine("Hello! Welcome to the Journal-o-rama");
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Remove");
        Console.WriteLine("6. Quit");
        Console.WriteLine("");

        string user_input ="";

        user_input=Console.ReadLine();
        int user_number = int.Parse(user_input);

        while (user_number != 6)
        {
            if (user_number==1)
            {
                Entry user_entry = new Entry();
                user_entry._promptText=user_prompt.GetRandomPrompt();
                Console.WriteLine(user_entry._promptText);
                user_entry._entryText=Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                user_entry._changeDate=dateText;
                user_journal.AddNewEntry(user_entry);
                
            }
            else if (user_number==2)
            {
                foreach (Entry item in user_journal._entries)
                {
                    item.DisplayEntry();
                }
            }
            else if (user_number==3)
            {
               user_journal._entries = user_journal.LoadFromFile("journal.txt");
            }
            else if (user_number==4)
            {
                user_journal.SaveToFile("journal.txt");
            }
            else if (user_number==5)
            {
                //This is my extra mile :) User can delete registers
                Console.WriteLine("What entry do you want to delete?");
                string delete_entry ="";
                delete_entry=Console.ReadLine();
                int delete_number=0;
                delete_number=int.Parse(delete_entry);
                user_journal.DeleteEntry(delete_number);
            }
            
        Console.WriteLine("What would you like to do now?");
        Console.WriteLine("");
         Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Remove");
        Console.WriteLine("6. Quit");
        Console.WriteLine("");


        user_input=Console.ReadLine();
        user_number = int.Parse(user_input);
       
        }

        Console.WriteLine("Thanks for using our app!");
        Console.WriteLine("See you next time!");
    
    }
}