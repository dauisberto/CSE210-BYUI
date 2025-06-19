using System;

class Program
{
    static void Main(string[] args)
    {
        // Core 1&2 requirements
        /*
        Console.WriteLine("Welcome to Number Akinator.");
        Console.WriteLine("You'll try to guess the magic number");
        string guesss="";
        string numbers="";
        string magic="";
        int guesss_number=0;
        int magic_number;
        Console.Write("What's the magic number? ");
        magic=Console.ReadLine();
        magic_number=int.Parse(magic);
        Console.WriteLine("");
        Console.Write("What's your guessing? ");
        guesss=Console.ReadLine();
        guesss_number=int.Parse(guesss);

        while (guesss_number!=magic_number)
        {
            Console.WriteLine("Nope, try again! ");
            if (guesss_number<magic_number)
            {
                Console.WriteLine("Higher!");
                Console.Write("What's your guessing? ");
                guesss=Console.ReadLine();
                guesss_number=int.Parse(guesss);
            }
            else if (guesss_number>magic_number)
            {
               Console.WriteLine("Lower!");
                Console.Write("What's your guessing? ");
                guesss=Console.ReadLine();
                guesss_number=int.Parse(guesss); 
            }
        }
        Console.WriteLine("Congrats! You guessed the number");
        */

        //Core 3 requirements
        Console.WriteLine("Welcome to Number Reverse Akinator.");
        Console.WriteLine("You must try to guess which number i'm thinking about");
        
        int keep_playing=0;
        int count=1;
        string keep ="";

        while (keep_playing==0)
        {
        Random randomGenerator = new Random();
        int akinator_number=randomGenerator.Next(1,100);
            Console.Write("What is your number guess? ");
            string guess = Console.ReadLine();
            int guess_number;
            guess_number=int.Parse(guess);

            while (guess_number!=akinator_number)
            {
                Console.WriteLine("Nope, try again! ");
                count +=1;
                if (guess_number<akinator_number)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess_number>akinator_number)
                {
                    Console.WriteLine("Lower! ");
                }
                Console.Write("What is your new guess? ");
                guess=Console.ReadLine();
                guess_number=int.Parse(guess);
            }

            Console.WriteLine("Congrats! You guessed it");
            Console.WriteLine($"You guessed it in {count} rows");
            Console.WriteLine("Would you like you play again? If so, type 0, otherwise, type any number");
            keep=Console.ReadLine();
            keep_playing=int.Parse(keep);
        }

    }
}