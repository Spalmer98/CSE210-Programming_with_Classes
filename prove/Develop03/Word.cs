using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        // need to figure out how to remove sections of words
    }

    private void Hide()
    {

    }

    private void Show()
    {

    }

    private bool IsHidden()
    {
        bool condition = _isHidden;
        return condition;
    }

    public string GetDisplayText()
    {
        string text = $"{_text}";
        return text;
    }
}