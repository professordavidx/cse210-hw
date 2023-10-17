using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public override string CreateGoal()
        {
            return $"{GetGoal()},{GetDescription()},{GetPoints()}";
        }
        public override string GetStringRepresentation()
        {
            return $"{GetGoal()} ({GetDescription()})";
        }
        // every time you call this override method will get the points previously set
        public override int RecordEvent()
        {
            return GetPoints();
        }
    }
}