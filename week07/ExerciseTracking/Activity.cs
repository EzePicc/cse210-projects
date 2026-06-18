using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    protected DateTime GetDate()
    {
        return _date;
    }

    protected int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateFormatted= _date.ToString("dd MM yy");
        
        return $"{dateFormatted}{GetActivityName()} {_lengthInMinutes} min - Distance:{GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace:{GetPace():0.00} min km";
    }
    protected abstract string GetActivityName();
}