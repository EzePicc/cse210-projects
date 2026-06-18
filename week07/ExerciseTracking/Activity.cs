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
}