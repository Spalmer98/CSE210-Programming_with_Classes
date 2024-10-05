using System;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private List<string> _word = new List<string>();

    private int _randomNumber;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        foreach(string str in text.Split(" "))
        {
            _word.Add(str);
            // Word word = new Word(str);
            // Console.Write(word.GetDisplayText());
        }
        HideRandomWords(10);
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        _randomNumber = randomGenerator.Next(0, numberToHide);
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} {_word[_randomNumber]}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool condition = false;
        return condition;
    }
}

// string.Join(" ", _word)