using System;

class Program
{
    static void Main(string[] args)
    {
        //Core 3 requirements
        Console.WriteLine("Welcome to Number Reverse Akinator.");
        Console.WriteLine("You must try to guess which number i'm thinking about");
        Random randomGenerator = new Random();
        int akinator_number=randomGenerator.Next(1,5);
        int keep_playing=0;
        int count=1;
        string keep ="";

        while (keep_playing==0)
        {

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
            Console.WriteLine("Would you like you play again? If so, type 0, otherwise, type any number");
            keep=Console.ReadLine();
            keep_playing=int.Parse(keep);
        }

    }
}