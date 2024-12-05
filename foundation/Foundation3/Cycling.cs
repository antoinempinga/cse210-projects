using System;

public class Cycling : Activity
{
    public double SpeedInMph { get; set; }

    public Cycling(DateTime date, int durationInMinutes, double speedInMph)
        : base(date, durationInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return (SpeedInMph * DurationInMinutes) / 60; // Distance in miles
    }

    public override double GetSpeed()
    {
        return SpeedInMph; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return 60 / SpeedInMph; // Pace in minutes per mile
    }

    protected override string GetSpeedUnits() => "mph";
    protected override string GetDistanceUnits() => "mile";
}
