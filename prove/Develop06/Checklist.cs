public class Checklist : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
    }

    public bool isComplete()
    {
        return true;
    }

    public override string GetDetails()
    {
        return base.GetDetails();
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {base._name} ({base._description}) --Currently completed: {_amountCompleted}/{_target}";
    }
}