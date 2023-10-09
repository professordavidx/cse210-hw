using System;

public class BreathingActivity : Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string name, string description): base(name,description)
    {
        //set breathing in and out as default here
        _breathIn = "Breath in ...";
        _breathOut = "Now breath out...";
    }

    public void DisplayBreathingActivity()
    {
        StartMessage();
        DateTime t = DurationInSeconds();
        while (DateTime.Now < t)
        {
            Console.WriteLine($"\n{_breathIn}");
            CountDown(4);
            Console.Write(_breathOut);
            CountDown(6);
        }
        DisplayEndingMessage();
    }
}