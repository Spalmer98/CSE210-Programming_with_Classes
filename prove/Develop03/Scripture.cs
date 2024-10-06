using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words {get; set;}

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(Random random)
    {
        if (_words.All(w => w._isHidden)) return;
        
        int numberToHide;
        do
        {
            numberToHide = random.Next(_words.Count);
        } while (_words[numberToHide]._isHidden);
        _words[numberToHide]._isHidden = true;
    }

    public void GetDisplayText()
    {
        Console.Write($"{_reference.GetDisplayText()} ");
        foreach (var word in _words)
        {
            Console.Write(word._isHidden ? "____ " : word.GetDisplayText());
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden => _words.All(w => w._isHidden);
}

// string.Join(" ", _word)