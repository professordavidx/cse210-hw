using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class SalaryEmployee: Employee
    {
        private float _salary = 0; // start as 0 as default

        public float GetSalary() // getter
        {
            return _salary;
        }

        public void SetSalary(float salary)
        {
            _salary = salary;
        }

        public override float GetPay() // use the word override
        {
            return _salary / 12;
        }
    }
}