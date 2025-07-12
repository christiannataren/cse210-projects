
class Menu
{
    public String UserInteraction()
    {
        ShowMenu();
        String response = GetResponse();
        return response;
    }
    public void ShowMenu()
    {
        talk("Welcome to the Journal Program!");
        talk("Please select one of the following choices:");
        talk("1. Write");
        talk("2. Display");
        talk("3. Load");
        talk("4. Save");
        talk("5. Delete");
        talk("6. Quit");
        talk("What would you like to do?");
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

    public String SelectJournal(List<string> savedJournals)
    {
        talk($"You have {savedJournals.Count} saved journals. Please select one option");
        int i = 1;
        foreach (String jnrl in savedJournals)
        {
            String parsed = jnrl.Split("/")[1].Split(".")[0];
            talk($"{i}. {parsed}");
            i = i + 1;
        }
        String number = GetResponse();
        String nombre = "";
        try
        {
            int index = int.Parse(number) - 1;
            nombre = savedJournals[index];
        }
        catch (Exception e)
        {
            Error();
            talk("Invalid Option.");
            return null;
        }
        return nombre;
    }
}