using System;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private List<string> _word = new List<string>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        foreach(string str in text.Split(" "))
        {
            _word.Add(str);
            // Word word = new Word(str);
            // Console.Write(word.GetDisplayText());
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} {_word[2]}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool condition = false;
        return condition;
    }
}

// string.Join(" ", _word)