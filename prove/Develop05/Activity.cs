using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _description;
    public int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_activityName}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for you session? ");
        _activityDuration = Console.Read();
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}