public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public int _totalEntries = 0;
    public int _entryNumber = 0;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
    public void LoadDisplayEntry()
    {
        Console.WriteLine($"Entry Number: {_entryNumber}");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}