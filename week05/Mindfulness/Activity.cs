using Microsoft.VisualBasic;

class Activity
{
    protected String _name, _description;
    protected int _duration;




    protected void DisplayStartingMessage()
    {

        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds would you like for your session? ");

    }

    protected void DisplayEndingMessage()
    {
        // print("");
        WellDone();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);

    }
    protected int ShowSpinner(int seconds)
    {

        int place = 1;
        for (int i = seconds; i > 0; i--)
        {

            switch (place)
            {
                case 1:
                    Console.Write("/");
                    break;
                case 2:
                    Console.Write("-");
                    break;
                case 3:
                    Console.Write("\\");
                    break;
                case 4:
                    Console.Write("|");
                    break;

            }
            place = place + 1;
            if (place == 5)
            {
                place = 1;
            }
            Thread.Sleep(700);
            Console.Write("\b \b");
        }
        Console.WriteLine("\b \b");
        return 0;
    }


    protected void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {

            // Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("\b \b");
    }
    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    protected void ReadDuration()
    {
        int seconds;
        String response = Console.ReadLine();
        int.TryParse(response, out seconds);
        _duration = seconds;
    }
    protected void print(String message)
    {
        Console.WriteLine(message);
    }
    protected void WellDone()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
    }

}