using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min) - Distance {GetDistance():0.0}, Speed {GetSpeed():0.0} {GetSpeedUnits()}, Pace: {GetPace():0.0} min per {GetDistanceUnits()}";
    }

    protected virtual string GetSpeedUnits() => "mph"; // Default speed units (could be overridden in derived classes).
    protected virtual string GetDistanceUnits() => "mile"; // Default distance units (could be overridden in derived classes).
}
