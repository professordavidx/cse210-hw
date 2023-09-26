public class Entry
{
    public DateTime _dateTime; 
    public string _prompt; 
    public string _answer;

    public void DisplayEntry()
    {
      string dateText = _dateTime.ToShortDateString();

      Console.WriteLine($"{dateText} {_prompt}");
      Console.WriteLine(_answer);
    }

}