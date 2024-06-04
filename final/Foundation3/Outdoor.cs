public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string weather) : base(title, description, date, time, street, city, state, country)
    {
        _weather = weather;
    }
    public string OutdoorFullDetails()
    {
        return $"{GetFullDetails("Outdoors")}\nWeather: {_weather}";
    }
    public string OutdoorShortDescription()
    {
        return GetShortDescription("Outdoors");
    }
}