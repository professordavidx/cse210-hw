public class WritingAssignment : Assignment
{
    string _tittle = "";

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _tittle = title;
    }

    public string GetWritingInformation()
    {
        return $"{_tittle}";
    }

}