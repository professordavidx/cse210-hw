using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class Menu
    {
        private List<string> _menu = new List<string>();
        private List<string> _subMenu = new List<string>();

        public void DisplayMenu()
        {
            _menu.Add("Menu Options:");
            _menu.Add("1. Create New Goal");
            _menu.Add("2. List Goals");
            _menu.Add("3. Save Goals");
            _menu.Add("4. Load Goals");
            _menu.Add("5. Record Event");
            _menu.Add("6. Quit");
            foreach (string item in _menu)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayGoalMenu()
        {
            _subMenu.Add("The types of Goals are:");
            _subMenu.Add(" 1. Simple Goal");
            _subMenu.Add(" 2. Eternal Goal");
            _subMenu.Add(" 3. Checklist Goal");

            foreach (string goalType in _subMenu)
            {
                Console.WriteLine(goalType);
            }
        }
    }
}