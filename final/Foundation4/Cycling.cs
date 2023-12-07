public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        return Speed * LengthMinutes / 60;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        double Distance = GetDistance();
        double Pace = GetPace();

        return $"{base.GetSummary()} - Distance: {Distance:F2} miles, Speed: {Speed:F2} mph, Pace: {Pace:F2} min per mile";
    }
}

