
class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _isComplete = false;

    }
    public SimpleGoal(string name, string description, int points, bool IsComplete)
    : base(name, description, points)
    {
        _isComplete = IsComplete;

    }


    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override List<string> GetStringRepresentation()
    {
        List<string> data = new List<string>();
        data.Add("SimpleGoal");
        data.Add(_shortName);
        data.Add(_description);
        data.Add(_points.ToString());
        data.Add(_isComplete.ToString());



        return data;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            GoalManager.me.AddScore(_points);
            _isComplete = true;
        }
        else
        {
            GoalAchieved();
        }


    }


}