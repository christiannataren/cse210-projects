class Swimming : Activity
{

    private double _numberLaps;
    public Swimming(DateTime date, double length, double numberLaps)
: base(date, length)
    {
        _numberLaps = numberLaps;

    }
    protected override double GetDistance()
    {
        return _numberLaps * 50 / 1000;
    }

    protected override double GetPace()
    {
        return _length / GetDistance();
    }

    protected override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
}