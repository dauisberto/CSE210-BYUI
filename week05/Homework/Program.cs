using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("Diego", "Idioms");
        Console.WriteLine($"{one.GetSummary()}");
        Console.WriteLine("");

        MathAssignment two = new MathAssignment("Valentina", "Fractions", "7.5.4", "8 to 12");
        Console.WriteLine($"{two.GetSummary()}");
        Console.WriteLine($"{two.GetHomeworkList()}");
        Console.WriteLine("");

        WritingAssignment three = new WritingAssignment("Gabriela", "Poems", "The roses are blue");
        Console.WriteLine($"{three.GetSummary()}");
        Console.WriteLine($"{three.GetWritingInformation()}");
        Console.WriteLine("");


    }
}