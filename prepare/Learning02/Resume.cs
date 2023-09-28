using System;

// 2. Create the class (Hint this is the public class Job syntax).
public class Resume 
{
//Create the member variable for the person's name.
    public string _name;
// Create the member variable for the list of Jobs. 
//(Hint: the data type for this should be List<Job> , 
//and it is probably easiest to initialize this to a new list right when you declare it..)
    public List<Job> _jobs = new List<Job>();
// Return to your Resume class and add a method to display its details.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
// iterate through each Job instance in the list of jobs and display them.
        foreach (Job job in _jobs)
        { 
            job.Display();
        }

    }
}