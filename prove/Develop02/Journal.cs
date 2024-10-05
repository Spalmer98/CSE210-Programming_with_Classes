using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    { 
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();
        newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}