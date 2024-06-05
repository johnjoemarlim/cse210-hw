public class Cycling : Activity
{
    private double _speed;
    public Cycling(double length, string date, double speed) : base(length, date)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _length / 60;
    }
    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}