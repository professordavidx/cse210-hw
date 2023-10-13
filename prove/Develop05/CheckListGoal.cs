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
        protected int _amountCompleted;
        protected int _target;
        protected int _bonus;

        public CheckListGoal(string name, string description , string points , int target , int bonus) : base (name,description,points)
        {
            _target = target;
            _bonus = bonus;
        }

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }

        public void SetAmountCompleted(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }

        public int GetTarget()
        {
            return _target;
        }

        public void SetTarget( int target)
        {
            _target = target;
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public void SetBonus( int bonus)
        {
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            
        }

        public override bool IsComplete()
        {
            return true; // I set it up as true in the meantime
        }

        public override string GetDetailString()
        {
            return  
        }

        public override string GetStringRepresentation()
        {
            return
        }

        







    }
}