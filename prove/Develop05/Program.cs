using System;
using System.Collections.Generic;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        SaveAndLoad sL = new SaveAndLoad();
        string user = "";
        do
        {
            Console.WriteLine($"\nYou have {sL.TotalXP()} points\n");
            Menu menu = new Menu();

            menu.DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();

            if (user == "1")
            {
                menu.DisplayGoalMenu();
                Console.Write("Which type of goal would you like to create? ");
                string user2 = Console.ReadLine();

                if (user2 == "1")
                {
                    SimpleGoal s = new SimpleGoal();
                    s.SetGoals();
                    sL.SetGoalToList(s);
                }
                if (user2 == "2")
                {
                    EternalGoal e = new EternalGoal();
                    e.SetGoals();
                    sL.SetGoalToList(e);
                }
                if (user2 == "3")
                {
                    CheckListGoal c = new CheckListGoal();
                    c.SetGoals();
                    c.SetBonus();
                    sL.SetGoalToList(c);
                }
            }

            if (user == "2")
            {
                sL.Spinner();
                sL.DisplayGoalList();
            }
            if (user == "3")
            {
                sL.SaveList();
            }
            if (user == "4")
            {
                sL.LoadGoals();
            }
            if (user == "5")
            {
                sL.Spinner();
                sL.CheckGoals();
            }

        }
        while (user != "6");
    }
}