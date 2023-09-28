using System;

// 2. Create the class (Hint this is the public class Job syntax).
public class Job
{        // 3. Create member variables in the class for each element that this class should contain. 
        // By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    public void Display()
        {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
        }

