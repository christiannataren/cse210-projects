using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }
        int adds = 0;
        int larger = 0;
        foreach (int n in numbers)
        {
            adds = adds + n;
            if (n > larger)
            {
                larger = n;
            }
        }
        double average = ((double)adds) / ((double)numbers.Count);
        Console.WriteLine($"The sum is: {adds}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {larger}");


    }

}