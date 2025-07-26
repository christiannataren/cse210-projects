using System.ComponentModel;

class Video
{

    private String _title;
    private String _author;
    private int _length;
    private List<Comment> _comments;
    public Video(String title, String author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }




    public void AddComment(String creator, String text)
    {
        _comments.Add(new Comment(creator, text));
    }
    public int GetCommentsNumber()
    {
        return _comments.Count();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: ({GetCommentsNumber()})");
        foreach (Comment c in _comments)
        {
            c.Display();
        }

    }


    public List<String> GetAllComments()
    {
        List<String> data = new List<string>();
        foreach (Comment coment in _comments)
        {
            data.Add(coment.GetCommentFormat());
        }

        return data;
    }


}