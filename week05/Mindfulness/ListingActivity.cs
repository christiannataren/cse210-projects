class ListingActivity : Activity
{

    private int _count;
    private List<String> _prompts, _listUser;



    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>();
        _listUser = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _count = 4;
    }



    public void Run()
    {
        DisplayStartingMessage();
        ReadDuration();
        GetReady();
        print("List as many responses you can to the following prompt:");
        print($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(_count);
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(_duration);
        while (future > DateTime.Now)
        {
            Console.Write("> ");
            String item = Console.ReadLine();
            if (item.Length > 0)
            {
                _listUser.Add(item);
            }
        }

        print($"You listed {_listUser.Count} items!");
        print("");
        DisplayEndingMessage();
    }


    private String GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
    private List<String> GetListFromUser()
    {
        return new List<string>();
    }
}