public class Running : Activity
{
    private double _distance;
    public Running(double length, string date, double distance) : base(length, date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Round(_distance / _length * 60, 2);    
    }
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace().ToString("0.##")} min per km";
    }
}