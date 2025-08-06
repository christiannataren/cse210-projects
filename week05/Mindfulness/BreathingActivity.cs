class BreathingActivity : Activity
{


    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }



    public void Run()
    {
        DisplayStartingMessage();
        ReadDuration();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (futureTime > DateTime.Now)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(6);

            Console.WriteLine("");
        }
        // WellDone();
        DisplayEndingMessage();


    }
}