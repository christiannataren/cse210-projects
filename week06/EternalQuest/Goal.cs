abstract class Goal
{

    protected String _shortName, _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public abstract void RecordEvent();

    public abstract Boolean IsComplete();

    public virtual String GetDetailsString()
    {

        string checkText = "";
        if (IsComplete())
        {
            checkText = "[x]";

        }
        else
        {
            checkText = "[ ]";

        }

        return $"{checkText} {_shortName} ({_description})";
    }

    public abstract List<String> GetStringRepresentation();

    public String GetName()
    {
        return _shortName;
    }

    protected void GoalAchieved()
    {
        Console.WriteLine("This goal has already been achieved.");
    }
}
