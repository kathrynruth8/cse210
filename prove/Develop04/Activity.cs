public class Activity
{
    // Atributes
    public string ActivityName {get; set; }
    public int ActivityDuration {get; set; }
    public string ActivityIntro {get; set; } 
    private string Message = "You may begin in...";

    // Constructors
    public Activity(string activityName, int activityDuration, string activityIntro)
    {
        ActivityName = activityName;
        ActivityDuration = activityDuration;
        ActivityIntro = activityIntro;
    }
    public void StartActivity()
    {
        Console.WriteLine(ActivityName);
        Console.WriteLine(ActivityIntro);
        Console.WriteLine(Message);
        Pause(3);
    }
    public void FinishActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {ActivityName} for {ActivityDuration} seconds.");
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