using System;

public class Entry
{
    public string _entryText;
    public string _date;
    public string _promptText = JournalPrompts.GetRandomPrompt();

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
    

}