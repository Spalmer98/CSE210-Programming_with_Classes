public class Listening : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Listening(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.WriteLine("Listening Test");
        Thread.Sleep(1500);
    }

    public void GetPrompt()
    {

    }

    public List<string> GetUserList()
    {
        List<string> userList = new List<string>();
        return userList;
    }

}