public class Activity
{
    // Atributes
    public string ActivityName {get; set; }
    public int ActivityDuration {get; set; }
    public string ActivityDescription {get; set; } //not sure this is needed
    private string Message = "You may begin in...";

    // Constructors
    public Activity(string activityName, int activityDuration, string activityDescription)
    {
        ActivityName = activityName;
        ActivityDuration = activityDuration;
        ActivityDescription = activityDescription;
    }
    public void StartActivity()
    {
        Console.WriteLine(ActivityName);
        Console.WriteLine(ActivityDescription);
        Console.WriteLine(Message);
        Pause(3);
    }
    public void FinishActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {ActivityName} for {ActivityDuration} seconds.");
        Pause(3);
    }
    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}