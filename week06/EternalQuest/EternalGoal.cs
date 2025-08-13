class EternalGoal : Goal
{

    public EternalGoal(String name, string description, int points)
    : base(name, description, points)
    {

    }
    public override List<string> GetStringRepresentation()
    {
        List<string> data = new List<string>();
        data.Add("EternalGoal");
        data.Add(_shortName);
        data.Add(_description);
        data.Add(_points.ToString());
        return data;
    }


    public override void RecordEvent()
    {
        GoalManager.me.AddScore(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }
}