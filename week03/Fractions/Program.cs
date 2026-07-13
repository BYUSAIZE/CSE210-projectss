using System;

class Program
{
    static void Main(string[] args)
    {
        // 1/1
        Fraction first = new Fraction();
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Console.WriteLine();

        // 5/1
        Fraction second = new Fraction(5);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Console.WriteLine();

        // 3/4
        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Console.WriteLine();

        // Using setters
        Fraction fourth = new Fraction();
        fourth.SetTop(1);
        fourth.SetBottom(3);

        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());
    }
}