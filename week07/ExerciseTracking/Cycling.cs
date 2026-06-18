using System;
public class Cycling: Activity
{
    private double _speed;
    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed= speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLengthInMinutes()) / 60;
    }
}