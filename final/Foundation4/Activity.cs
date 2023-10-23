using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Activity
    {
        private DateTime _date;
        protected int _length; //In minutes


        public Activity(DateTime date, int length)
        {
            _date = date;
            _length = length;
        }

        // Get distance in kilometers
        public virtual double GetDistance()
        {
            return 0;
        }
        //kilometers per hour
        public virtual double GetSpeed()
        {
            return 0;
        }
        //minutes length per kilometer
        public virtual double GetPace()
        {
            return 0;
        }

        public virtual string GetActivitySummary()
        {
            return $"{_date:d MMM yyyy} {GetType()} ({_length} min)";
        }
    }
}