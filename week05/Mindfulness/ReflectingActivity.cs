class ReflectingActivity : Activity
{

    private List<String> _prompts, _questions, _used;
    private int _questionDuration = 10;


    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect or yout life.";
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        CopyQuestions();
    }



    public void Run()
    {
        DisplayStartingMessage();
        ReadDuration();
        GetReady();
        print("Consider the following prompt:");
        DisplayPrompt();
        print("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        print("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(_duration);
        while (future > DateTime.Now)
        {
            DisplayQuestions();
        }
        print("");
        DisplayEndingMessage();
    }


    private String GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
    private void CopyQuestions()
    {
        _used = new List<string>(_questions);
    }
    private String GetRandomQuestion()
    {
        if (_used.Count == 0)
        {
            CopyQuestions();
            print("Questions will be reset.");
        }
        String question = _used[new Random().Next(_used.Count)];
        _used.Remove(question);
        return question;
    }
    private void DisplayPrompt()
    {
        print($"--- {GetRandomPrompt()}");

    }

    private void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(_questionDuration);
    }

}