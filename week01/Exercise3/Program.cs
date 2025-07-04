using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Guess the number");
        int magic = new Random().Next(1, 101);
        Boolean guessed = false;
        while (!guessed)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == magic)
            {
                guessed = true;
            }
            else
            {
                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
            if (guessed)
            {
                Console.WriteLine("Congratulations you guessed it.");
                Console.Write("Would you like to play again? y/n ");
                String answer = Console.ReadLine();
                if (answer == "y" || answer == "Y")
                {
                    guessed = false;
                    magic = new Random().Next(1, 101);
                }
            }
        }
        

    }
}