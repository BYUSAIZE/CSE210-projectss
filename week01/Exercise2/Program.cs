using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());

        string letter;

        if (percent >= 80)
        {
            letter = "A";
        }
        else if (percent >= 70)
        {
            letter = "B";
        }
        else if (percent >= 60)
        {
            letter = "C";
        }
        else if (percent >= 55)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
            Console.WriteLine("Well Done!");
        else
            Console.WriteLine("Try Again Later!");
    }
}