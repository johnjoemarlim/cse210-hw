public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void LoadDisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.LoadDisplayEntry();
        }
    }
    public void SaveToFile(string file)
    {
        
        string fileName = file;
        
        int counter = 0;

      
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            foreach (Entry entry in _entries)
            {
                counter = counter + 1;
                entry._entryNumber = counter;
                outputFile.WriteLine($"{entry._entryNumber}~~{entry._date}~~{entry._entryText}~~{entry._promptText}");
            }
            
        }
    }
    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        int b = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Entry anEntry = new Entry();
            b = int.Parse(parts[0]);
            anEntry._date = parts[1];
            anEntry._entryText = parts[2];
            anEntry._promptText = parts[3];

            _entries.Add(anEntry);
            anEntry._entryNumber = b;
        }
    
    }
}