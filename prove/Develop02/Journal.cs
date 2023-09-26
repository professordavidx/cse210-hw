public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(DateTime dateTime, string prompt, string answer)
    {
        _entries.Add(new Entry() {_dateTime = dateTime, _prompt = prompt , _answer = answer});
    }
    public void DisplayAllEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }


    public void SaveJournal(string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                
                outputFile.WriteLine($"{entry._dateTime.ToShortDateString()}|{entry._prompt}|{entry._answer}");    
            }
        }
    }
 
    public void LoadJournal(string fileName)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            _entries.Add(new Entry() {_dateTime = DateTime.Parse(parts[0]), _prompt = parts[1] , _answer = parts[2]});
            
        }
    }

}

