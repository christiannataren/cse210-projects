using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction one = new Fraction();
        Console.WriteLine($"{one.GetFractionString()} = {one.GetDecimalValue()}");
        Fraction two = new Fraction(5);
        Console.WriteLine($"{two.GetFractionString()} = {two.GetDecimalValue()}");
        Fraction three = new Fraction(1, 3);
        Console.WriteLine($"{three.GetFractionString()} = {((double)three.GetDecimalValue())}");
    }



}