using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Lectures: Event
    {
        private string _speaker;
        private int _capacity;

        public Lectures(string speaker, int capacity, Address address, string title, string description, string eventType, string date, string time, string eventInformation) : base(address, title, description, eventType, date, time, eventInformation)
        {
            _speaker = speaker;
            _capacity = capacity;
        }
        public void GetFullDetails()
        {
            FullDetails();
            Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
        }
        public void DisplayMarketingTemplate()
        {
            Console.WriteLine("Short description:\n");
            Console.WriteLine(StandarDetails);
            Console.WriteLine("\nFull details presentation:\n");
            GetFullDetails();
            Console.WriteLine("\nShort description:\n");
            Console.WriteLine(ShortDescription);
        }
    }
}