using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (0 to quit): ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            numbers.Add(number);
        }

        int sum = 0;
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}