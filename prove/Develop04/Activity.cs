using System;

public class Activity
{
    // Atributes
    private string _activityName;
    private int _activityDuration;
    private string _activityDescription; //not sure this is needed
    private string _message = "You may begin in...";

    // Constructors
    public Activity(string activityName, int activityDuration)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
    }
    public string GetActivityName()
    {
        return _activityName;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

}