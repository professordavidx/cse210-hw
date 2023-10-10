using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class HourlyEmployee : Employee
    {
        private float _payRate = 0; //value set as default
        private int _hoursWorked = 0;

        public float GetPayRate()
        {
            return _payRate;
        }

        public void SetPayRate(float payRate)
        {
            _payRate = payRate;
        }

        public float GetHoursWorked()
        {
            return _hoursWorked;
        }

        public void SetHoursWorked(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }

        public override float GetPay() // Careful it has to match the same info 
        {
            return _hoursWorked * _payRate;
        }
    }
}