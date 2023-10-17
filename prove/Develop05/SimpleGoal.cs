using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public override string CreateGoal()
        {
            return $"{GetGoal()},{GetDescription()},{GetPoints()},{GetCheck()}";
        }
        public override string GetStringRepresentation()
        {
            return $"{GetGoal()} ({GetDescription()})";
        }
        public override int RecordEvent()
        {
            Console.Clear();
            int totalPoints = 0;

            if (_isCheck == false)
            {
                SetCheck(true);
                totalPoints = GetPoints();
            }
            else
            {
                Console.WriteLine("Goal already Completed! Create another one.\n");
            }
            return totalPoints;
        }
    }
}