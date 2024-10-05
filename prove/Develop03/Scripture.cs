using System;

public class Scripture
{
    private Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        foreach(string str in text.Split(" "))
        {
            Word word = new Word(str);
        }
        // HideRandomWords(10);
    }

    public void HideRandomWords(int numberToHide)
    {
        // Random randomGenerator = new Random();
        // _randomNumber = randomGenerator.Next(0, numberToHide);
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} ";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool condition = false;
        return condition;
    }
}

// string.Join(" ", _word)