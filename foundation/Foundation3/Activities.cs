using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
