using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to your BYUI Grade Calculator");
        Console.Write("What is your current grade? ");
        
        string user_grade = Console.ReadLine();
        int grade = int.Parse(user_grade);
        
        string letter="";
        if (grade>=90)
        {
            if (grade>=93)
            {
                letter = "A";
            }
            else
            {
                letter="A-";
            }
        }
        else if (grade>=80)
        {
            if (grade>=87)
            {
                letter="B+";
            }
            else if (grade>83)
            {
                letter="B";
            }
            else if (grade<=83)
            {
                letter="B-";
            }
        }
        else if (grade>=70)
        {
            if (grade>=77)
            {
                letter="C+";
            }
            else if(grade>73)
            {
                letter="C";
            }
            else if(grade<=73)
            {
                letter="C-";
            }
        }
        else if (grade>=60)
        {
            if (grade>=67)
            {
                letter="D+";
            }
            else if (grade>60)
            {
                letter="D";
            }
            else if(grade<=63)
            {
                letter="D-";
            }
        }
        else
        {
            letter="F";
        }
        
        Console.WriteLine($"Your grade is {letter}");
        Console.WriteLine("");
        
        if (grade>=70)
        {
            Console.WriteLine("Congrats! You're approving your course");
        }
        else
        {
            Console.WriteLine("You're not approving your course. We count on you, do your better!!");
        }
    }
}