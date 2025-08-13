class Running : Activity
{
    private double _distance;
    public Running(DateTime date, double length,double distance)
: base(date, length)
    {
        _distance = distance;

    }

    protected override double GetDistance()
    {
        return _distance;
    }

    protected override double GetPace()
    {
        return 60 / GetSpeed();
    }

    protected override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
}