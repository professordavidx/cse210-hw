using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class OutdoorGatherings: Event
    {
        private string _weatherForecast;

        public OutdoorGatherings(string weather, Address address, string title, string description, string eventType, string date, string time, string eventInformation) : base(address, title, description, eventType, date, time, eventInformation)
        {
            _weatherForecast = weather;
        }
        public void GetFullDetails()
        {
            FullDetails();
            Console.WriteLine($"Weather statement: {_weatherForecast}");
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