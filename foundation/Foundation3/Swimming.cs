using System;

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to kilometers (50 meters per lap)
        return (Laps * 50) / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // Pace in minutes per kilometer
    }

    protected override string GetSpeedUnits() => "kph";
    protected override string GetDistanceUnits() => "km";
}
