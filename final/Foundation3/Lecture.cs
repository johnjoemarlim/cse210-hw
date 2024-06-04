public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string LectureGetFullDetails()
    {
        return $"{GetFullDetails("Lecture")}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public string LectureGetShortDescription()
    {
        return GetShortDescription("Lecture");
    }
}