class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, double length, double speed)
: base(date, length)
    {
        _speed = speed;

    }




    protected override double GetDistance()
    {
        return (GetSpeed() * _length) / 60;
    }

    protected override double GetPace()
    {
        return 60 / GetSpeed();
    }

    protected override double GetSpeed()
    {
        return _speed;
    }
}