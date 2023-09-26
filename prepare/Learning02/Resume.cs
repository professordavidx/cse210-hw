public class Resume
{
    public string _name;
    public List<Job> _Jobs = new List<Job>();

    public void  DisplayResume()
    {
        Console.WriteLine($"{_name}");

        foreach(Job job in _Jobs)
        {
            job.DisplayJob();
        }
    }
}