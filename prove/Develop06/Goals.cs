public abstract class Goals
{
    public string _name;
    public string _description;
    public string _points;

    protected Goals(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetails()
    {
        return $"{_name}, {_description}, {_points}, {IsComplete()}";
    }

    public abstract string GetStringRepresentation();
}