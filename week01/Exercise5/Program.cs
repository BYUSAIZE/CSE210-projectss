using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, favoriteNumber, squaredNumber);

        Console.WriteLine("\nThank you for using the Number Squaring Program!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("      WELCOME TO THE NUMBER SQUARER");
        Console.WriteLine("===========================================");
        Console.WriteLine("This program will square your favorite number.");
        Console.WriteLine();
    }

    static string PromptUserName()
    {
        Console.Write("👤 Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        int number;

        Console.Write("🔢 Enter your favorite number: ");

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("❌ Invalid input. Please enter a whole number: ");
        }

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int originalNumber, int squaredNumber)
    {
        Console.WriteLine();
        Console.WriteLine("========== RESULT ==========");
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your favorite number is: {originalNumber}");
        Console.WriteLine($"The square of {originalNumber} is: {squaredNumber}");
        Console.WriteLine("============================");
    }
}