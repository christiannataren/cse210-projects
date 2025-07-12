class Entry
{
    public String _content;
    public DateTime _date;
    public String _prompt;
    public Entry(String entry_text, String prompt)
    {
        _content = entry_text;
        _prompt = prompt;
        _date = DateTime.Now;
    }
    public Entry(String entry_text, String prompt, String date)
    {
        _content = UnParseContent(entry_text);
        _prompt = prompt;
        _date = DateTime.Parse(date);

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("MM/dd/yyyy")} - Prompt: {_prompt}");
        Console.WriteLine($"{_content}");
    }
    public String GetContent()
    {
        return $"{_date.ToString("MM/dd/yyyy")}|{_prompt}|{ParseContent()}";
    }

    public String ParseContent()
    {
        String parse = "0x1987";
        return _content.Replace("|", parse);
    }

    public String UnParseContent(String entry_text)
    {
        String parse = "0x1987";
        return entry_text.Replace(parse, "|");
    }
}