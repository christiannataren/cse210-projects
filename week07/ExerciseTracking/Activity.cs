abstract class Activity
{
    protected DateTime _date;
    protected double _length;
    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }
    protected abstract double GetDistance();
    protected abstract double GetPace();
    protected abstract double GetSpeed();


    public String GetSummary()
    {
        String date = String.Format("{0:d MMM yyyy}", _date);
        return $"{date} {this.GetType().Name.ToString()} ({_length} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }


}