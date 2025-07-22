////////////To exceed requirements, I added a system that allows the user to set the number of words the program will hide.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Menu menu = new Menu(new Scripture(new Reference("Matthew", 11, 5, 7), "The blind receive their sight, and the lame walk, the lepers are cleansed, and the deaf hear, the dead are raised up, and the poor have the gospel preached to them. And blessed is he, whosoever shall not be offended in me. And as they departed, Jesus began to say unto the multitudes concerning John, What went ye out into the wilderness to see? A reed shaken with the wind?"));
        menu.start();
    }
}