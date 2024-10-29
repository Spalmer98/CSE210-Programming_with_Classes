public class Eternal : Goals
{
    public Eternal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {base._name} ({base._description})";
    }
}