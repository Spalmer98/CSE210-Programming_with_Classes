using System;

public class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        string text = $"{_text} ";
        return text;
    }
}