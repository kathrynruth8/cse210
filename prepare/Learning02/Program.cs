using System;

class Program
{
    static void Main(string[] args)
    {   // Create a new job instance named job1 .
        Job job1 = new Job();
        // Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        // Verify that you can display the company of this job on the screen, again using the dot notation to 
        // access the member variable.

        // Create a second job, set its variables, display this company on the screen as well.
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Return to your Program.cs. Add the end of the Main function, create a new instance of the Resume class.
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        // Add the two jobs you created earlier, to the list of jobs in the resume object.
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle 
        // add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.
        resume1.Display();
    }
}