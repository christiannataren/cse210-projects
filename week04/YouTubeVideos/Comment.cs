class Comment
{
    private String _creator;
    private String _text;

    public Comment(String creator, String text)
    {
        _creator = creator;
        _text = text;


    }
    public String GetCommentFormat()
    {
        return $"{_creator}: {_text}";
    }
    public void Display()
    {
        Console.WriteLine($"    * {_creator}: {_text}");
    }
}