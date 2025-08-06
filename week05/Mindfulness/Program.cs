// I have added logic to avoid repeating questions, 
// as well as a notification that prompts when all questions have been used. 
// At that point, the questions will be reset so they can all be used again.
using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Run();
    }
}