public class BreathingActivity : Activity
{
    private string BreathingIntro = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, int activityDuration)
        : base(activityName, activityDuration, "")
    {
        ActivityIntro = BreathingIntro; // Assigning BreathingIntro to ActivityIntro
    }

    public void StartBreathing()
    {
        StartActivity();
        int totalDuration = ActivityDuration;

        int breathDuration = 4;
        int holdDuration = 3;

        while (totalDuration > 0)
        {
            if (totalDuration >= breathDuration)
            {
                Console.WriteLine("Breathe in...");
                Pause(breathDuration);
                totalDuration -= breathDuration;
            }

            if (totalDuration >= holdDuration)
            {
                Console.WriteLine("Hold...");
                Pause(holdDuration);
                totalDuration -= holdDuration;
            }

            if (totalDuration >= breathDuration)
            {
                Console.WriteLine("Breathe out...");
                Pause(breathDuration);
                totalDuration -= breathDuration;
            }

            if (totalDuration >= holdDuration)
            {
                Console.WriteLine("Hold...");
                Pause(holdDuration);
                totalDuration -= holdDuration;
            }
        }

        FinishActivity();
    }
}