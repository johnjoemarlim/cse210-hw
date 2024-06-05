public class Swimming : Activity
{
    private double _laps;
    public Swimming(double length, string date, int laps) : base(length, date)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / _length * 60, 2);
    }
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}