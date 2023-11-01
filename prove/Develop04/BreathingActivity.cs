public class BreathingActivity : Activity
{
    private string _breathingIntro = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, int activityDuration)
        :base(activityName, activityDuration)
    {
        
    }
// 1.The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// 2. The description of this activity should be something like: "This activity will help 
// you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."

// 3. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."

// 4. After each message, the program should pause for several seconds and show a countdown.

// 5. It should continue until it has reached the number of seconds the user specified for the duration.

// 6. The activity should conclude with the standard finishing message for all activities.
}