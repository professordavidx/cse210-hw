using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Receptions: Event
    {
        private string _emailRSVP;

        public Receptions(string email, Address address, string title, string description, string eventType, string date, string time, string eventInformation) : base(address, title, description, eventType, date, time, eventInformation)
        {
            _emailRSVP = email;
        }
        public void GetFullDetails()
        {
            Console.WriteLine($"sent to: {_emailRSVP}");
            Console.WriteLine("Please respond!\n");
            FullDetails();
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