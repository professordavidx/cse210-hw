using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        List<string> menu = new List<string>();
        menu.Add("Menu options:");
        menu.Add(" 1. Start breathing activity");
        menu.Add(" 2. Start reflecting Activity");
        menu.Add(" 3. Start listing activity");
        menu.Add(" 4.Quit");
        menu.Add("Select a choice fro the menu:");

        do
        {
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }
            user = Console.ReadLine();

            if (user == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "Smile, breath, and take it slow. Doing this will help you relax. ");
                breathing.DisplayBreathingActivity();
            }

            else if (user == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity helps you look back on times in your life when you've shown strength and resilience. \n It enables you to recognize your own power and how you can apply it in different areas of your life.");
                reflecting.DisplayReflectingActivity();
            }

            else if (user == "3")
            {
                ListingActivity listing = new ListingActivity("Listing activity", "This activity will have you make a list to help you remember and ponder good moments \n in your life so that you may continue to have meaning and purpose in your own journey.");
                listing.DisplaylistingActivity();
            }

        }
        while (user != "4");
        Console.Clear();
        Console.WriteLine("Thank you for your time!");
    }
}