public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private int _counter;
    public Reflection(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.WriteLine("Reflection Test");
        Thread.Sleep(1500);
    }

    public string GetPrompt()
    {
        return "NULL";
    }
    
    public string GetQuestion()
    {
        return "NULL";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {
        
    }
}