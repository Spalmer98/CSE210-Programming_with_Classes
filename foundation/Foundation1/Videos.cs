using System;

public class Videos
{
    public string _title;
    public string _author;
    public double _length;
    private List<Comments> _comments = new List<Comments>();

    public void GetComments(string author, string text)
    {
        Comments comment = new Comments(author, text);
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}\nAuthor: {_author}\nLength of Video: {_length} sec\nNumber of Comments: {_comments.Count}");
        foreach(Comments comment in _comments)
        {
            comment.Display();
        }
    }
}