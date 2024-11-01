public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        int i = 0;
        int duration = _activityDuration;
        Console.WriteLine("Get ready...");

        while (i != (duration / 5))
        {
            Console.WriteLine("Breath In");
            Thread.Sleep(3000);
            Console.WriteLine("Breath Out");
            Thread.Sleep(3000);
            i = i + 1;
        }

        DisplayEndingMessage();
        
    }
}