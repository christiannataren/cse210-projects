using System;

class Program
{
    public static Menu _menu;
    public static Journal _journal;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        _journal = new Journal();
        _menu = new Menu();
        while (true)
        {
            String response = _menu.UserInteraction();
            ExecuteResponse(response);

        }

    }


    public static void ExecuteResponse(String response)
    {
        int option;
        try
        {
            option = int.Parse(response);

        }
        catch (Exception e)
        {
            _menu.talk("XXXXXXXX Invalid option XXXXXXXXXX Invalid option XXXXXXXXXXXXXXXXX Invalid option XXXXXXXXXXXXXXX");
            return;
        }
        switch (option)
        {
            case 1:
                _menu.talk("Writing a new Entry");
                String prompt = PromptGenerator.GetPrompt();
                _menu.talk(prompt);
                String entry_text = _menu.GetResponse();
                _journal.AddEntry(entry_text, prompt);
                break;
            case 2:
                _journal.DisplayJournal();
                break;
            case 4:
                if (_journal.CountEntries() <= 0)
                {
                    _menu.Error();
                    _menu.talk("You can not save an empty journal. Try option 1. Write");
                    break;
                }
                _menu.talk("Enter a name.");
                String filename = _menu.GetResponse();
                if (_journal.Save(filename))
                {
                    _menu.talk($"{filename} saved successfully.");
                }
                else
                {
                    _menu.Error();
                    _menu.talk($"Error saving {filename}");
                }
                break;
            case 3:
                List<String> savedJournals = _journal.GetSavedJournals();
                if (savedJournals.Count <= 0)
                {
                    _menu.Error();
                    _menu.talk("No saved journals found.");
                    return;
                }
                _menu.talk("|||Loading|||");
                String nombre = _menu.SelectJournal(savedJournals);
                if (nombre == null)
                {
                    return;
                }
                _journal.Load(nombre);
                break;
            case 5:
                savedJournals = _journal.GetSavedJournals();
                if (savedJournals.Count <= 0)
                {
                    _menu.Error();
                    _menu.talk("No saved journals found.");
                    return;
                }
                _menu.talk("|||Deleting|||");
                nombre = _menu.SelectJournal(savedJournals);
                if (nombre == null)
                {
                    return;
                }
                _menu.talk($"Are you sure to delete {nombre.Split("/")[1].Split(".")[0]} file? yes/no");
                response = _menu.GetResponse().ToLower();
                if (response == "yes")
                {
                    if (_journal.Delete(nombre))
                    {
                        _menu.talk($"{nombre.Split("/")[1].Split(".")[0]} deleted successfully.");
                    }
                    else
                    {
                        _menu.Error();
                        _menu.talk($"Error deleting {nombre.Split("/")[1].Split(".")[0]} ");
                    }
                }
                else
                {
                    _menu.talk("Deletion cancelled");
                }



                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                _menu.Error();
                _menu.talk("Invalid option");
                break;

        }

    }
}