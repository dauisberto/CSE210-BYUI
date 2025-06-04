using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Scripture Memorizer 3000!");
        Console.WriteLine("The first thing we need from you is  to tell us which scripture will you");
        Console.WriteLine("memorize today? ");
        Console.WriteLine("");
        Console.WriteLine("These are the options:");
        Console.WriteLine("");
        Console.WriteLine("1. Abraham 3:24-25");
        Console.WriteLine("2. Phillipians 2:7-8");
        Console.WriteLine("3. Psalm 23:1");
        Console.WriteLine("");
        Console.WriteLine("Please type the number (1, 2 or 3) of the scripture you'd like");
        Console.WriteLine("");

        string userScripture = Console.ReadLine();
        int userScriptureNumber = int.Parse(userScripture);

        //Here is my extra-mile for creativity. User could choose a scripture from a list displayed


        Reference generic = new Reference("", 0, 0, 0);
        Reference AbeReference = new Reference("Abraham", 3, 24, 25);
        Reference PhilReference = new Reference("Phillipians", 2, 7, 8);
        Reference PsalmReference = new Reference("Psalm", 23, 1);
        string AbrahamText = "And there stood one among them that was like unto God and he said unto those who were with him We will go down for there is spance there and we will take of these materials and we will make an earth whereon these may dwell And we will prove them herewith to see if they will do all things whatsoever the Lord their God shall command them";
        string PhilText = "But made himself of no reputation and took upon him the form of a servand and was made in the likeness of men And being found in fashion as a man he humbled himself and became obedient unto death even the death of the cross";
        string PsalmText = "The Lord is my shepherd i shal not want";
        Scripture Abraham = new Scripture(AbeReference, AbrahamText);
        Scripture Phillipians = new Scripture(PhilReference, PhilText);
        Scripture Psalm = new Scripture(PsalmReference, PsalmText);


        Scripture practiceScripture = new Scripture(generic, "");


        if (userScriptureNumber == 1)
        {
            practiceScripture = Abraham;
        }
        else if (userScriptureNumber == 2)
        {
            practiceScripture = Phillipians;
        }
        else if (userScriptureNumber == 3)
        {
            practiceScripture = Psalm;
        }

        string userTyping = "";
        bool end = false;

        while (end == false)
        {
            Console.Clear();
            Console.WriteLine(practiceScripture.GetDisplayText());
            Console.WriteLine("Please press 'Enter' or type 'quit' to finish");
            userTyping = Console.ReadLine();

            if (userTyping.ToUpper() == "QUIT")

            {
                Console.WriteLine("");
                Console.WriteLine("Bye!");
                end = true;
            }
            else
            {
                practiceScripture.HideRandomWords(2);

                if (practiceScripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(practiceScripture.GetDisplayText());
                    Console.WriteLine("Now all of the words are hidden. Bye!");
                    end = true;
                }
            }

        }




    }
}