using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class SaveAndLoad
    {
        private List<Goal> _goalList = new List<Goal>();
        private List<string> _goalListString = new List<string>();
        private List<string> _animation = new List<string>();
        private int _total;
        private Goal g;

        public void SetGoalToList(Goal g)
        {
            _goalList.Add(g);
        }
        public int TotalXP()
        {
            return _total;
        }
        public void Spinner()
        {

            int i = 0;
            _animation.Add("|");
            _animation.Add("/");
            _animation.Add("-");
            _animation.Add("\\");
            _animation.Add("|");
            _animation.Add("/");
            _animation.Add("-");
            _animation.Add("\\");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);

            while (DateTime.Now < endTime)
            {
                string s = _animation[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;
            }
            Console.Clear();
        }
        public void SaveList()
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_total);
                foreach (Goal goal in _goalList)
                {
                    outputFile.WriteLine($"{goal}:,{goal.CreateGoal()}");
                }
            }
        }
        public void DisplayGoalList()
        {
            int count = 0;
            Console.WriteLine("The goals are: \n");
            foreach (Goal g in _goalList)
            {
                count++;
                if (g.GetCheck() == true)
                {
                    string x = "X";
                    Console.WriteLine($"{count}. [{x}] {g.GetStringRepresentation()}");
                }
                else
                {
                    Console.WriteLine($"{count}. [ ] {g.GetStringRepresentation()}");
                }
            }
        }
        public void LoadGoals()
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string t = reader.ReadLine();
                _total = Convert.ToInt32(t);
            }
            // save the first line which is the total points in the txt file and then skip that part to start reading the file
            string[] goals = System.IO.File.ReadAllLines(fileName);
            goals = goals.Skip(1).ToArray();

            foreach (string g in goals)
            {
                string[] parts = g.Split(",");

                string type = parts[0];
                string goal = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                if (type == "SimpleGoal:")
                {
                    string check = parts[4];
                    bool booleanValue = bool.Parse(check);

                    SimpleGoal s = new SimpleGoal();

                    s.SetGoal(goal);
                    s.SetDescription(description);
                    s.SetPoints(points);
                    s.SetCheck(booleanValue);
                    _goalList.Add(s);
                }
                if (type == "EternalGoal:")
                {
                    EternalGoal e = new EternalGoal();

                    e.SetGoal(goal);
                    e.SetDescription(description);
                    e.SetPoints(points);
                    _goalList.Add(e);
                }
                if (type == "ChecklistGoal:")
                {
                    int bonus = Convert.ToInt32(parts[4]);
                    int target = Convert.ToInt32(parts[5]);
                    int completed = Convert.ToInt32(parts[6]);

                    CheckListGoal c = new CheckListGoal();

                    c.SetGoal(goal);
                    c.SetDescription(description);
                    c.SetPoints(points);
                    c.SetBonus(bonus);
                    c.SetTargets(target);
                    c.Setcompleted(completed);

                    if (completed == target)
                    {
                        c.SetCheck(true);
                    }
                    _goalList.Add(c);
                }
                // if the user hasn't load the goal file then show a message to the console!
                if (goals.Count() == 0)
                {
                    Console.WriteLine("You don't have not added any goal yet! go ahead and make\n a new one or load the file");
                }
            }
        }
        // This method will make use of the method RecordEvent in each goal class we desired to check
        public void CheckGoals()
        {
            int count = 0;

            if (_goalList.Count() == 0)
            {
                Console.WriteLine("There are not goals here :(");
                Console.WriteLine("Create or load the goals");
            }
            else
            {
                Console.WriteLine("The goals are: \n");
                foreach (Goal g in _goalList)
                {
                    count++;
                    Console.WriteLine($"{count}. {g.GetGoal()}");
                }
                Console.Write("Select a goal: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                selection -= 1;

                if (selection <= _goalList.Count() - 1)
                {
                    Goal finished = _goalList[selection];
                    int addPoints = finished.RecordEvent();
                    _total += addPoints;

                    if (addPoints != 0)
                    {
                        Console.WriteLine($"Congrats! You just earned {addPoints} points\n");
                    }
                }
                else
                {
                    Console.WriteLine($"{selection + 1} is not in the list!\n");
                }

            }
        }
    }
}