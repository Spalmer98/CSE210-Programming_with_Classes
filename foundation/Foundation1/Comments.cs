using System;
using System.Net;

public class Comments
{
    public string _author;
    public string _text;

    public Comments(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_author}: {_text}");
    }
}