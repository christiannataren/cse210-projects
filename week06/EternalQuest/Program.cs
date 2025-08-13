////////////To exceed requirements, I've added a system to load goals from a list of files on a menu, as well as the option to delete any required file from the menu options.
using System;

class Program
{
    static void Main(string[] args)
    {
        new GoalManager().Start();
    }
}