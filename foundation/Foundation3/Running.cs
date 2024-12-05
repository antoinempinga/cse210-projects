using System;

public class Running : Activity
{
    public double DistanceInMiles { get; set; }

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        DistanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return DistanceInMiles;
    }

    public override double GetSpeed()
    {
        return (DistanceInMiles / DurationInMinutes) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInMiles; // Pace in minutes per mile
    }

    protected override string GetSpeedUnits() => "mph";
    protected override string GetDistanceUnits() => "mile";
}
