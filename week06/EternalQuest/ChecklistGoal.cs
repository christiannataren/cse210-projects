class ChecklistGoal : Goal
{
    private int _amountCompleted, _target, _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {

        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed)
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override List<string> GetStringRepresentation()
    {
        List<string> data = new List<string>();
        data.Add("CheckListGoal");
        data.Add(_shortName);
        data.Add(_description);
        data.Add(_points.ToString());
        data.Add(_bonus.ToString());
        data.Add(_target.ToString());
        data.Add(_amountCompleted.ToString());

        return data;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            GoalManager.me.AddScore(_points);
            _amountCompleted += 1;
            if (_amountCompleted == _target)
            {
                GoalManager.me.AddScore(_bonus);
            }
        }
        else
        {
            GoalAchieved();
        }



    }
    public override string GetDetailsString()

    {
        string checkText;
        if (_amountCompleted >= _target)
        {
            checkText = "[X]";
        }
        else
        {
            checkText = "[ ]";
        }


        return $"{checkText} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}