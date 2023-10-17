using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Develop05
{
    public class CheckListGoal : Goal
    {
        private int _completed;
        public int _bonus;
        private int _target;

        public void SetBonus()
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            _target = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            _bonus = Convert.ToInt32(Console.ReadLine());
        }
        // This Get and Set methods will be used in other functions where the user don't see that working
        public void SetBonus(int bonus)
        {
            _bonus = bonus;
        }
        public int GetBonus()
        {
            return _bonus;
        }
        public void SetTargets(int target)
        {
            _target = target;
        }
        public int GetTargets()
        {
            return _target;
        }
        public void Setcompleted(int completed)
        {
            _completed = completed;
        }
        public int Getcompleted(int completed)
        {
            return _completed;
        }
        // here is where the polymorphism works, check if is different in other class. Just check the override methods
        public override string CreateGoal()
        {
            return $"{GetGoal()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_completed}";
        }
        public override string GetStringRepresentation()
        {
            return $"{GetGoal()} ({GetDescription()}) -- currently completed: {_completed}/{_target}";
        }
        public override int RecordEvent()
        {
            _completed++;
            int totalPoints = 0;
            if (_completed == _target)
            {
                SetCheck(true);
                totalPoints = GetPoints() + _bonus;
            }
            else if (GetCheck() == true)
            {
                Console.WriteLine("Goal already completed! Create another one.\n");
            }
            else
            {
                totalPoints = GetPoints();
            }
            return totalPoints;
        }
    }
}