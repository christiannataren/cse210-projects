using System.Threading.Tasks.Dataflow;

class Journal
{

    public List<Entry> _entries;
    private String _file_extension = ".jnrl";



    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            entry.Display();
            Console.WriteLine("");
        }

    }
    public Boolean Save(String filename)
    {
        String saving = "";
        foreach (Entry entry in _entries)
        {
            saving += entry.GetContent() + "\n";
        }
        try
        {
            File.WriteAllText(filename + _file_extension, saving);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }

    }

    public void Load(String filename)
    {
        String loading = File.ReadAllText(filename);
        String[] lines = loading.Split("\n");
        _entries.Clear();
        foreach (String line in lines)
        {
            if (line.Length <= 1)
            {
                continue;
            }
            String[] unparse = line.Split("|");
            _entries.Add(new Entry(unparse[2].Trim(), unparse[1].Trim(), unparse[0].Trim()));

        }
    }

    public void AddEntry(String entry_text, String prompt)
    {
        _entries.Add(new Entry(entry_text, prompt));

    }

    public int CountEntries()
    {
        return _entries.Count;
    }

    public List<String> GetSavedJournals()
    {

        List<String> journals = new List<string>();
        String[] files = Directory.GetFiles("./");
        foreach (String file in files)
        {
            if (file.Contains(_file_extension))
            {
                journals.Add(file);
            }
        }

        return journals;
    }

    public Boolean Delete(string nombre)
    {
        try
        {
            File.Delete(nombre);
            return true;

        }
        catch (Exception e)
        {

        }
        return false;
    }
}