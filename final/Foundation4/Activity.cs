public class Activity
{
    public DateTime Date {get; set; }
    public int LengthMinutes {get; set; }

    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} - {GetType().Name} ({LengthMinutes} min)";
    }
}
