using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Event
    {
        private string _title;
        private string _description;
        private string _eventType;
        private string _date;
        private string _time;
        private string _eventInformation;
        private Address _address;

        public Event(Address address, string title, string description, string eventType, string date, string time, string eventInformation)
        {
            _address = address;
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _eventType = eventType;
            _eventInformation = eventInformation;
        }
        public string StandarDetails
        {
            get { return $"Title: {_title}\nDescription: {_description} on {_date} at {_time}\nAddress: {_address.FullAddress}"; }
        }

        // This method Contains the base information of the event, child class will have this method and more details
        public void FullDetails()
        {
            Console.WriteLine(StandarDetails);
            Console.WriteLine($"Event: {_eventType}");
            Console.WriteLine($"Specific information: {_eventInformation}");
        }

        public string ShortDescription
        {
            get { return $"Event: {_eventType}\nTitle: {_title}\nDate: {_date}"; }
        }
    }
}