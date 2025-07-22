
class Menu
{
    private Scripture _scripture;
    private int _hiddingWords;
    private String _message = "Press enter to continue, 'quit' to exit, or a number to set words to hide";
    public Menu(Scripture scripture)
    {
        _scripture = scripture;
        _hiddingWords = new Random().Next(1, 5);

    }
    public String UserInteraction()
    {


        String text = _scripture.GetDisplayText();
        talk(text);
        talk(_message + $" Current({_hiddingWords}):");
        String response = GetResponse();

        return response;
    }

    public String GetResponse()
    {
        Console.Write(">");
        return Console.ReadLine();
    }



    public void talk(String text)
    {
        Console.WriteLine(text);
    }

    public void Error()
    {
        talk("XXXXXXXXERRORXXXXERRORXXXXERRORXXXXXXXXERRORXXXXXXXXX");
    }

    public void start()
    {
        while (true)
        {
            String response = UserInteraction().ToLower();

            if (response == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                int toHide;
                if (int.TryParse(response, out toHide))
                {
                    if (toHide > 0)
                    {
                        _hiddingWords = toHide;
                    }
                }
                if (!_scripture.HideRandomWords(_hiddingWords))
                {
                    Environment.Exit(0);
                }
            }
        }
    }

}