public abstract class Goals
{
    public string _name;
    public string _description;
    private string _points;

    protected Goals(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetails()
    {
        return "";
    }

    public abstract string GetStringRepresentation();
}