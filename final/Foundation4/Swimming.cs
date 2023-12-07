public class Swimming : Activity
{
    public int Laps {get; set; }

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62; // Convert meters to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        double Distance = GetDistance();
        double Speed = GetSpeed();
        double Pace = GetPace();

        return $"{base.GetSummary()} - Distance: {Distance:F2} miles, Speed: {Speed:F2} mph, Pace: {Pace:F2} min per mile";
    }
}