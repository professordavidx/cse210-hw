using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goal
    {
        protected int _score;
        private string _description;
        private int _points;
        private string _goal;
        protected bool _isCheck;
        public void SetGoals()
        {
            Console.Write("what is the name of your goal? ");
            _goal = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            _points = Convert.ToInt32(Console.ReadLine());
        }
        public string GetGoal()
        {
            return _goal;
        }
        public void SetGoal(string goal)
        {
            _goal = goal;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public int GetPoints()
        {
            return _points;
        }
        public void SetPoints(int points)
        {
            _points = points;
        }
        public void SetScore(int score)
        {
            _score += score;
        }
        public int GetScore()
        {
            return _score;
        }
        public void SetCheck(bool isCheck)
        {
            _isCheck = isCheck;
        }
        public bool GetCheck()
        {
            return _isCheck;
        }
        public abstract string CreateGoal();
        public abstract int RecordEvent();
        public abstract string GetStringRepresentation();
    }
}