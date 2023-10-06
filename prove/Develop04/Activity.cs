public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetActivityName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"{_description}\n");

    }

    public void ShowSpinner(int num = 7)
    {
        List<string> animation = new List<string>();
        int i = 0;
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(num);

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
        }
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}" );
        ShowSpinner();
        Console.Clear();
    }

    public void CountDown(int num = 0)
    {
        for (int i = num; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }

    public void BeginActivity()
    {
        Console.WriteLine("You may begin in: ");
        CountDown(5);
    }

    public void 




}

