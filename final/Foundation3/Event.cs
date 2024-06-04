using System.Security.Cryptography.X509Certificates;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city, state, country);
    }
    public string GetStandardDetails()
    {
        return $"{_title} - {_description}\n{_date} @ {_time}\n{_address.StringAddress()}";
    }
    public virtual string GetFullDetails(string type)
    {
        return $"Type: {type}\n{_title} - {_description}\n{_date} @ {_time}\n{_address.StringAddress()}";
    }
    public virtual string GetShortDescription(string type)
    {
        return $"{type} - {_title} - {_date}";
    }
}