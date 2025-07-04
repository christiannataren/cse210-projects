using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(String name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}