public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / LengthMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / Distance;
    }

    public override string GetSummary()
    {
        string DistanceUnit = "miles";
        double DistanceValue = Distance;

        double Speed = GetSpeed();
        double Pace = GetPace();

        return $"{base.GetSummary()} - Distance: {DistanceValue:F2} {DistanceUnit}, Speed: {Speed:F2} mph, Pace: {Pace:F2} min per {DistanceUnit}";
    }
}