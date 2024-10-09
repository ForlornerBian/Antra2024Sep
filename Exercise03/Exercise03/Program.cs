namespace _Exercise03;

using System;

class Program
{
    static void Main()
    {
        // Question 1
        
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
        
        // int max = 500;
        // for (byte i = 0; i < max; i++)
        // {
        //     Console.WriteLine(i);
        // }
        
        // The code lead to an infinite loop because the maximum value for a byte is 255. Once i reaches 255, it will 
        // wrap around to 0 again due to byte overflow, and the loop will never terminate.
        // We can change the code to the following mode: 
        
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            if (i == byte.MaxValue)
            {
                Console.WriteLine("Warning: i has reached its maximum value for byte!");
                break;
            }
            Console.WriteLine(i);
        }
        
        // Question 2
        
        int totalRows = 5;

        for (int row = 1; row <= totalRows; row++)
        {
            // Print leading spaces
            for (int spaces = totalRows - row; spaces > 0; spaces--)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int stars = 1; stars <= (2 * row - 1); stars++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        
        // Question 3
        
        Random random = new Random();
        int correctNumber = random.Next(1, 4);  // Random number between 1 and 3
        
        Console.WriteLine("Guess the number (1 to 3): ");
        int guessedNumber = int.Parse(Console.ReadLine());
        
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is out of range.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Too low!");
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Correct!");
        }
        
        // Question 4
        
        DateTime birthDate = new DateTime(1990, 4, 9);
        DateTime today = DateTime.Now;

        TimeSpan age = today - birthDate;
        int daysOld = age.Days;

        Console.WriteLine($"You are {daysOld} days old.");

        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

        Console.WriteLine($"Your next 10,000-day anniversary will be on: {nextAnniversary.ToShortDateString()}");
        
        // Question 5
        
        DateTime currentTime = DateTime.Now;

        int hour = currentTime.Hour;

        if (hour >= 5 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 12 && hour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (hour >= 17 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        if (hour >= 21 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }
        
        // Question 6
        
        for (int increment = 1; increment <= 4; increment++)
        {
            for (int i = 0; i <= 24; i += increment)
            {
                Console.Write(i);
                if (i != 24)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}