using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        String grade = "";
        Console.Write("Insert your grade percentage: ");
        int number = int.Parse(Console.ReadLine());
        int sign_check = number % 10;
        String sign = "";
        if (sign_check >= 7)
        {
            sign = "+";
        }
        else if (sign_check <= 3)
        {
            sign = "-";
        }
        if (number >= 90)
        {
            grade = "A";
            if (sign == "+" || number == 100)
            {
                sign = "";
            }
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
            sign = "";
        }
        Boolean passed = false;
        if (number >= 70)
        {
            passed = true;
        }
        String passed_message = "did not pass, Better luck next time!";
        if (passed)
        {
            passed_message = "passed, Congratulations.";
        }
        Console.WriteLine($"You {passed_message} Grade: {grade}{sign}");

    }
}