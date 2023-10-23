using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("750 S 2nd St E", "Rexburg", "ID", "83440");

        Lectures event1 = new Lectures("Luis M. Castillo", 60, address, "Carlos Birthday", "Celebrate carlo's birthdate at his house", "Lecture", "7/15/2023", "8:00 PM", "Casual dress code");
        Receptions event2 = new Receptions("laurin171125@gmail.com", address, "Mike and Ashley's wedding", "Toast to our marriage!", "Reception", "7/16/2023", "7:00 PM", "The wedding is in the beach please wear white shirt");
        OutdoorGatherings event3 = new OutdoorGatherings("The sun is expected to rise at 10:00 AM and set at 5:45 PM", address, "Family meeting", "Let's have a picnic in the park", "Outdoor Gathering", "7/17/2023", "10:50 AM", "Bring board games and other games to play as a team");

        //  Display all template types with different description and marketing
        event1.DisplayMarketingTemplate();
        Console.WriteLine("-------------------------------");
        event2.DisplayMarketingTemplate();
        Console.WriteLine("-------------------------------");
        event3.DisplayMarketingTemplate();
    }
}