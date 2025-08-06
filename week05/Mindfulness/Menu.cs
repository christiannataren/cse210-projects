class Menu
{
    private String _principal = "Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity. \n 3. Start listing activity \n 4. Quit \n Select a choice from menu: ";
    private BreathingActivity _breath;
    private ReflectingActivity _reflecting;
    private ListingActivity _listing;
    public Menu()
    {
        _breath = new BreathingActivity();
        _listing = new ListingActivity();
        _reflecting = new ReflectingActivity();
    }


    private void SelectOption(String response)
    {
        int option;
        int.TryParse(response, out option);
        switch (option)
        {


            case 1:
                _breath.Run();
                break;
            case 2:
                _reflecting.Run();
                break;
            case 3:
                _listing.Run();
                break;
            case 4:
                Environment.Exit(0);
                break;
            case 0:
            default:
                Console.WriteLine("Invalid Option");
                break;


        }

    }

    public void Run()
    {
        while (true)
        {
            Console.Write(_principal);
            SelectOption(read());


        }

    }

    public String read()
    {
        return Console.ReadLine();
    }


}